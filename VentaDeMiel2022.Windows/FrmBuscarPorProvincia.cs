using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Windows.Helpers;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmBuscarPorProvincia : Form
    {
        public FrmBuscarPorProvincia()
        {
            InitializeComponent();
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (ProvinciaComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ProvinciaComboBox, "Debe seleccionar una provincia");
            }

            return valido;
        }

      

        private void FrmBuscarPorProvincia_Load_1(object sender, EventArgs e)
        {
            HelperCombos.CargarDatosComboPais(ref ProvinciaComboBox);

        }

        private void ProvinciaComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ProvinciaComboBox.SelectedIndex > 0)
            {
                provincia = (Provincia)ProvinciaComboBox.SelectedItem;
            }
            else
            {
                provincia = null;
            }
        }
        private Provincia provincia;
        public Provincia GetTipo()
        {
            return provincia;
        }
    }
}
