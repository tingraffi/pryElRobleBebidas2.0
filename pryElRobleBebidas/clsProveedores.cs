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
    internal class clsProveedores
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

        private string Tabla = "Proveedores";



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

        public void Eliminar(int Codigo)
        {
            try
            {
                string connectionString = GetConnectionString();

                using (OleDbConnection conexion = new OleDbConnection(connectionString)) 
                {
                    conexion.Open();
                    using (OleDbCommand comando = new OleDbCommand($"DELETE FROM {Tabla} WHERE Codigo = @Codigo", conexion)) 
                    {
                        comando.Parameters.AddWithValue("@Codigo", Codigo); 
                        int rowsAffected = comando.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No se encontró el registro a eliminar."); 
                        }
                        else
                        {
                            MessageBox.Show("Proveedor eliminado exitosamente.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void Modificar(int codigo, string nuevoNombre, string nuevaDireccion, string nuevoTelefono)
        {
            try
            {
                string connectionString = GetConnectionString();

                using (OleDbConnection conexion = new OleDbConnection(connectionString)) // Uso de using para asegurar el cierre de la conexión
                {
                    conexion.Open();
                    using (OleDbCommand comando = new OleDbCommand($"UPDATE {Tabla} SET Nombre = @NuevoNombre, Direccion = @NuevaDireccion, Telefono = @NuevoTelefono WHERE Codigo = @Codigo", conexion)) // Asegurarse de que el comando se crea con la conexión abierta
                    {
                        comando.Parameters.AddWithValue("@NuevoNombre", nuevoNombre); // Añadir parámetro correctamente
                        comando.Parameters.AddWithValue("@NuevaDireccion", nuevaDireccion); // Añadir parámetro correctamente
                        comando.Parameters.AddWithValue("@NuevoTelefono", nuevoTelefono); // Añadir parámetro correctamente
                        comando.Parameters.AddWithValue("@Codigo", codigo); // Añadir parámetro correctamente
                        int rowsAffected = comando.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No se encontró el registro a modificar."); // Mensaje si no se encuentra el registro
                        }
                        else
                        {
                            MessageBox.Show("Registro modificado exitosamente."); // Mensaje si el registro se modifica correctamente
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
    



