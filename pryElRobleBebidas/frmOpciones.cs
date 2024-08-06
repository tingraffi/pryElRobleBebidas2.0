using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryElRobleBebidas
{
    public partial class frmOpciones : Form
    {
        public frmOpciones()
        {
            InitializeComponent();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaProveedores frm = new frmCargaProveedores();
            frm.ShowDialog();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListadoDeProveedores frm = new frmListadoDeProveedores();
            frm.ShowDialog();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock();
            frm.ShowDialog();
        }

        private void bebidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListadoDeStock frm = new frmListadoDeStock();
            frm.ShowDialog();
        }

        private void graficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ventasMensuales2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graficos frm = new Graficos();
            frm.ShowDialog();
        }

        private void porcentajeDeVentasDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPorcentajeVtas frm = new frmPorcentajeVtas();
            frm.ShowDialog();
        }

        private void tablaDeVentas2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImprimir frm = new frmImprimir();
            frm.ShowDialog();
        }

        private void porcentajeVentasXEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImprimirPorcVtasEmpl frm = new frmImprimirPorcVtasEmpl();
            frm.ShowDialog();
        }

        private void grillaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImprimirGrillaProveedores frm = new frmImprimirGrillaProveedores();
            frm.ShowDialog();
        }

        private void grillaDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImprimirGrillaStock frm = new frmImprimirGrillaStock();
            frm.ShowDialog();
        }
    }
}
