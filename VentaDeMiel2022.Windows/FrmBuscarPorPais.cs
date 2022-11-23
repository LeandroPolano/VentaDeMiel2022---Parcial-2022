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
    public partial class FrmBuscarPorPais : Form
    {
        public FrmBuscarPorPais()
        {
            InitializeComponent();
        }
        private Pais pais;

        
        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void FrmBuscarPorPais_Load(object sender, EventArgs e)
        {
            HelperCombos.CargarDatosComboPais(ref PaisComboBox);

        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (PaisComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PaisComboBox, "Debe seleccionar un pais");
            }

            return valido;
        }

        private void TipoProductosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaisComboBox.SelectedIndex > 0)
            {
                pais = (Pais)PaisComboBox.SelectedItem;
            }
            else
            {
                pais = null;
            }
        }

        public Pais GetTipo()
        {
            return pais;
        }
    }
}
