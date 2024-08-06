using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryElRobleBebidas
{
    public partial class frmCargaProveedores : Form
    {
        public frmCargaProveedores()
        {
            InitializeComponent();
        }

        private string GetConnectionString()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = "BaseStock2.mdb"; 
            string fullPath = Path.Combine(basePath, relativePath);

            return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={fullPath}";
        }


        private void RegistrarProvedores()
        {
            string Nombre = txtNombre.Text;
            int Barrio = Convert.ToInt32(cmbBarrio.Text);
            int TipoBebidas = Convert.ToInt32(cmbTipoBebidas.Text);
            int Localidad = Convert.ToInt32(cmbLocalidad.Text);

            string connectionString = GetConnectionString();

            if (!File.Exists(connectionString.Split('=')[2]))
            {
                MessageBox.Show("La base de datos no se encuentra en la ruta especificada.");
                return;
            }

            string query = "INSERT INTO Proveedores (Nombre, Barrio, TipoBebidas, Localidad) VALUES (?, ?, ?, ?)";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("?", Nombre);
                        command.Parameters.AddWithValue("?", Barrio);
                        command.Parameters.AddWithValue("?", TipoBebidas);
                        command.Parameters.AddWithValue("?", Localidad);
                     
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Proveedor agregado correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtNombre.Clear();
            cmbBarrio.SelectedIndex = -1;
            cmbTipoBebidas.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
        }

      
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            RegistrarProvedores();
        }

       
    }
}
