using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace pryElRobleBebidas
{
    internal class clsGrabar
    {
        OleDbConnection conexionBD;
        DirectoryInfo rutaProyecto = new DirectoryInfo(@"../..");
        string cadenaConexion;
        public bool estadoConexion;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorDS;
        DataSet objDataSet = new DataSet();
        public clsGrabar()
        {
            estadoConexion = false;
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Path.Combine(rutaProyecto.FullName, "bin\\Debug\\basedeusuarios.mdb");
        }
        public void ConectarBaseDatos()
        {
            try
            {
                conexionBD = new OleDbConnection(cadenaConexion);
                conexionBD.Open();
                estadoConexion = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        public bool ValidarUsuarios(String Usuario, String Contraseña)
        {
            bool usuarioValido = false;
            try
            {
                if (conexionBD == null || conexionBD.State != ConnectionState.Open)
                {
                    ConectarBaseDatos();
                }

                string consulta = "SELECT * FROM Users WHERE Nombre = @Usuario AND Contraseña = @Contraseña";

                using (OleDbCommand cmd = new OleDbCommand(consulta, conexionBD))
                {
                    cmd.Parameters.AddWithValue("@Usuario", Usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioValido = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message);
            }
            return usuarioValido;
        }
        public void RegistroUsuarios(String usuario, String contraseña)
        {
            try
            {
                if (conexionBD == null || conexionBD.State != ConnectionState.Open)
                {
                    ConectarBaseDatos();
                }

                string consulta = "SELECT * FROM Users";
                comandoBD = new OleDbCommand(consulta, conexionBD);
                comandoBD.CommandType = CommandType.Text;

                adaptadorDS = new OleDbDataAdapter(comandoBD);
                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorDS);
                adaptadorDS.Fill(objDataSet, "Users");

                DataTable tablaGrabar = objDataSet.Tables["Users"];
                DataRow filaGrabar = tablaGrabar.NewRow();

                filaGrabar["Nombre"] = usuario;
                filaGrabar["Contraseña"] = contraseña;
                tablaGrabar.Rows.Add(filaGrabar);

                adaptadorDS.Update(objDataSet, "Users");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message);
            }
        }


    }
}





