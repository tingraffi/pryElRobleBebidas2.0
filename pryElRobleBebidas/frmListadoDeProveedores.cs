using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryElRobleBebidas
{
    public partial class frmListadoDeProveedores : Form
    {

        private int selectedRecordCodigo;

        public frmListadoDeProveedores()
        {
            InitializeComponent();
            dgvDatosBaseDatos.CellDoubleClick += DgvDatosBaseDatos_CellDoubleClick; 
        }

        clsProveedores objBaseDatos = new clsProveedores();

        private void btnListarProveedores_Click(object sender, EventArgs e)
        {
            objBaseDatos.Listar(dgvDatosBaseDatos);
        }

        private void frmListadoDeProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedRecordCodigo > 0)
            {
                objBaseDatos.Eliminar(selectedRecordCodigo); 
                objBaseDatos.Listar(dgvDatosBaseDatos);
                selectedRecordCodigo = 0;
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar."); 
            }
        }

        private void DgvDatosBaseDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDatosBaseDatos.Rows[e.RowIndex];
                selectedRecordCodigo = Convert.ToInt32(row.Cells["Codigo"].Value); 
            }
        }
    }
}
