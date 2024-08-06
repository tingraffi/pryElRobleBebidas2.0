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
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryElRobleBebidas
{
    public partial class frmPorcentajeVtas : Form
    {
        public frmPorcentajeVtas()
        {
            InitializeComponent();
            LoadChartData2();
        }

        private void LoadChartData2()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\VtasElRoble.mdb";
            string query = "SELECT Nombre, Porcentaje FROM VentasEmpleados";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Configurar el gráfico
                chart2.Series.Clear();
                var series = new Series("Ventas del 2023")
                {
                    ChartType = SeriesChartType.Pie // Tipo de gráfico de torta
                };

                foreach (DataRow row in dataTable.Rows)
                {
                    series.Points.AddXY(row["Nombre"].ToString(), Convert.ToDouble(row["Porcentaje"]));
                }

                chart2.Series.Add(series);
                chart2.ChartAreas[0].AxisX.Title = "Nombre";
                chart2.ChartAreas[0].AxisY.Title = "$Porcentaje";
            }
        }













        private void frmPorcentajeVtas_Load(object sender, EventArgs e)
        {

        }
    }
}
