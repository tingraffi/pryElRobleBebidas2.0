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
    public partial class frmRegistrarse : Form
    {
        public frmRegistrarse()
        {
            InitializeComponent();
        }

        clsGrabar objAcceso = new clsGrabar();

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtContraseña2.Text)
            {
                objAcceso.RegistroUsuarios(txtUsuario.Text, txtContraseña.Text);
                MessageBox.Show("Su usuario se ha registrado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void frmRegistrarse_Load(object sender, EventArgs e)
        {

        }
    }
}
