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
    public partial class frmListadoDeStock : Form
    {
        private int selectedRecordCodigoBebida;

        public frmListadoDeStock()
        {
            InitializeComponent();
            dgvDatosBaseDatos.CellDoubleClick += DgvDatosBaseDatos_CellDoubleClick;
        }
        clsStockBebidas objBaseDatos = new clsStockBebidas();

        private void btnListarStock_Click(object sender, EventArgs e)
        {
            objBaseDatos.Listar(dgvDatosBaseDatos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (selectedRecordCodigoBebida > 0)
            {
                objBaseDatos.Eliminar(selectedRecordCodigoBebida); // Llamada al método Eliminar con el CodigoBebida seleccionado
                objBaseDatos.Listar(dgvDatosBaseDatos); // Actualización de la grilla después de la eliminación
                selectedRecordCodigoBebida = 0; // Reset del campo después de la eliminación
            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar."); // Mensaje si no se ha seleccionado un registro
            }
        }

        private void DgvDatosBaseDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDatosBaseDatos.Rows[e.RowIndex];
                selectedRecordCodigoBebida = Convert.ToInt32(row.Cells["CodigoBebida"].Value); // Obtención del valor de CodigoBebida de la fila seleccionada
               
            }
        }

      
    }
}

