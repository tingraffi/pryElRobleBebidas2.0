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
    public partial class Graficos : Form
    {
        public Graficos()
        {
            InitializeComponent();
            LoadChartData();
        }

        private void LoadChartData()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\VtasElRoble.mdb";
            string query = "SELECT Mes, Numero FROM Ventas";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Configurar el gráfico
                chart1.Series.Clear();
                var series = new Series("Ventas del 2023")
                {
                    ChartType = SeriesChartType.Bar // Tipo de gráfico de barras
                };

                foreach (DataRow row in dataTable.Rows)
                {
                    series.Points.AddXY(row["Mes"].ToString(), Convert.ToDouble(row["Numero"]));
                }

                chart1.Series.Add(series);
                chart1.ChartAreas[0].AxisX.Title = "Mes";
                chart1.ChartAreas[0].AxisY.Title = "$Millones";
            }
        }

        private void Graficos_Load(object sender, EventArgs e)
        {

        }
    }
}
