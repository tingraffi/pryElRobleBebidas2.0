using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;

namespace pryElRobleBebidas
{
    public partial class frmImprimirPorcVtasEmpl : Form
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=;VtasElRoble.mdb";

        public frmImprimirPorcVtasEmpl()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.Pd_PrintPage);


            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();


                string query = "SELECT Nombre, Porcentaje FROM VentasEmpleados";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {

                        Font font = new Font("Arial", 12);
                        float yPos = 100;
                        while (reader.Read())
                        {
                            string data = reader["Nombre"].ToString() + ": " + reader["Porcentaje"].ToString();
                            e.Graphics.DrawString(data, font, Brushes.Black, new PointF(100, yPos));
                            yPos += 20;
                        }
                    }
                }
            }
        }
    }
}
