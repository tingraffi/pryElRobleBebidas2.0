using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace pryElRobleBebidas
{
    public partial class frmImprimirGrillaProveedores : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BaseStock2.mdb";
        private DataGridView dataGridView = new DataGridView();

        public frmImprimirGrillaProveedores()
        {
            InitializeComponent();
            LoadData();
            
        }

        private void LoadData()
        {
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(dataGridView);

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Codigo, Nombre, Barrio, TipoBebidas, Localidad FROM Proveedores";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                }
            }
        }

        


        private void frmImprimirGrillaProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.Pd_PrintPage);

            PrintDialog printDialog = new PrintDialog
            {
                Document = pd
            };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            int y = 100;
            Font font = new Font("Arial", 12);
            int rowHeight = dataGridView.RowTemplate.Height + 5;

            // Print headers
            for (int j = 0; j < dataGridView.Columns.Count; j++)
            {
                e.Graphics.DrawString(dataGridView.Columns[j].HeaderText, font, Brushes.Black, new PointF(100 + j * 100, y));
            }
            y += rowHeight;

            // Print rows
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    e.Graphics.DrawString(dataGridView.Rows[i].Cells[j].Value?.ToString(), font, Brushes.Black, new PointF(100 + j * 100, y));
                }
                y += rowHeight;
            }
        }
    }
}
