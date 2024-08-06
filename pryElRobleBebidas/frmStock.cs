using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace pryElRobleBebidas
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
            
        }
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Martin\\Desktop\\pryElRobleBebidas (1)\\pryElRobleBebidas\\pryElRobleBebidas\\bin\\Debug\\BaseStock2.mdb";
        

        private string GetConnectionString()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = "BaseStock2.mdb"; 
            string fullPath = Path.Combine(basePath, relativePath);

            return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={fullPath}";
        }

        private void RegistrarBebidas()
        {
            string Nombre = txtNombre.Text;
            string Marca = txtMarca.Text;
            int Tamaño = Convert.ToInt32(cmbTamaño.Text);
            int Envase = Convert.ToInt32(cmbEnvase.Text);
            int TipoBebidas = Convert.ToInt32(cmbTipoBebidas.Text);
            int Cantidad = Convert.ToInt32(txtCantidad.Text);
            int PrecioUnidad = Convert.ToInt32(txtPrecioUnidad.Text);
            int Proveedor = Convert.ToInt32(cmbProveedores.Text);

            string connectionString = GetConnectionString();

            if (!File.Exists(connectionString.Split('=')[2]))
            {
                MessageBox.Show("La base de datos no se encuentra en la ruta especificada.");
                return;
            }

            string query = "INSERT INTO BEBIDAS (Nombre, Marca, Tamaño, Envase, TipoBebidas, Cantidad, Proveedor, PrecioUnidad) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Marca", Marca);
                        command.Parameters.AddWithValue("@Tamaño", Tamaño);
                        command.Parameters.AddWithValue("@Envase", Envase);
                        command.Parameters.AddWithValue("@TipoBebidas", TipoBebidas);
                        command.Parameters.AddWithValue("@Cantidad", Cantidad);
                        command.Parameters.AddWithValue("@Proveedor", Proveedor);
                        command.Parameters.AddWithValue("@PrecioUnidad", PrecioUnidad);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Bebida agregada correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearFields();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            RegistrarBebidas();
        }

        private void ClearFields()
        {
            txtNombre.Clear();
            txtMarca.Clear();
            cmbTipoBebidas.SelectedIndex = -1;
            cmbTamaño.SelectedIndex = -1;
            cmbEnvase.SelectedIndex = -1;
            txtCantidad.Clear(); // Limpia el campo de cantidad
            txtPrecioUnidad.Clear();
            cmbProveedores.SelectedIndex = -1;
        }

        private void LoadData()
        {
            string connectionString = GetConnectionString();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM BEBIDAS", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
            }
        }
    }
}
