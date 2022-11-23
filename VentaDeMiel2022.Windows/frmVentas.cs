using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop2022.Windows
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void NuevoIconButton_Click(object sender, EventArgs e)
        //{
        //    frmVentasAE frm = new frmVentasAE() {Text = "Nueva Venta"};
        //    DialogResult dr = frm.ShowDialog(this);
        //}

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
