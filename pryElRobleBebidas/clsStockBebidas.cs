using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace pryElRobleBebidas
{
    internal class clsStockBebidas
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string GetConnectionString()
        {
            string basePath = Application.StartupPath;
            string relativePath = "BaseStock2.mdb"; 
            string fullPath = Path.Combine(basePath, relativePath);

            return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={fullPath}";
        }

        private string Tabla = "Bebidas";

        public void Listar(DataGridView Grilla)
        {
            try
            {
                string connectionString = GetConnectionString();

                string dbFilePath = connectionString.Split('=')[2];
                if (!File.Exists(dbFilePath))
                {
                    MessageBox.Show("El archivo de base de datos no existe en la ruta especificada.");
                    return;
                }

               

                conexion.ConnectionString = connectionString;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                Grilla.DataSource = ds.Tables[0];
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Eliminar(int CodigoBebida)
        {
            try
            {
                string connectionString = GetConnectionString();

                using (OleDbConnection conexion = new OleDbConnection(connectionString)) // Uso de using para asegurar el cierre de la conexión
                {
                    conexion.Open();
                    using (OleDbCommand comando = new OleDbCommand($"DELETE FROM {Tabla} WHERE CodigoBebida = @CodigoBebida", conexion)) // Asegurarse de que el comando se crea con la conexión abierta
                    {
                        comando.Parameters.AddWithValue("@CodigoBebida", CodigoBebida); // Añadir parámetro correctamente
                        int rowsAffected = comando.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No se encontró el registro a eliminar."); // Mensaje si no se encuentra el registro
                        }
                        else
                        {
                            MessageBox.Show("Registro eliminado exitosamente."); // Mensaje si el registro se elimina correctamente
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Captura y muestra cualquier excepción
            }

        }
    }
}





