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
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;
using VentaDeMiel2022.Windows.Helpers;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmProvinciaAE : Form
    {
        private IServicioPais servicio;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioPaises();
            //CargarDatosComboTipos(ref TipoProductosComboBox);
            HelperCombos.CargarDatosComboPais(ref PaisComboBox);
            if (provincia != null)
            {
                ProvinciaTextBox.Text = provincia.NombreProvincia;
               
                PaisComboBox.SelectedValue = provincia.PaisId;

            }
        }
        public FrmProvinciaAE()
        {
            InitializeComponent();
        }

        private Provincia provincia;
        public Provincia GetProvincia()
        {
            return provincia;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (ValidarDatos())
                {
                    if (provincia == null)
                    {
                        provincia = new Provincia();
                    }

                    provincia.NombreProvincia = ProvinciaTextBox.Text;
                    provincia.PaisId = ((Pais)PaisComboBox.SelectedItem).PaisId;
                    //provincia.NombrePais = (Pais)PaisComboBox.SelectedItem;




                    DialogResult = DialogResult.OK;
                }
            }
            
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ProvinciaTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ProvinciaTextBox, "La descripción es requerida");
            }
            if (PaisComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PaisComboBox, "Debe seleccionar un Pais");
            }

            return valido;
        }

        private void FrmProvinciaAE_Load(object sender, EventArgs e)
        {

        }

        public void SetProvincia(Provincia provincia1)
        {
            this.provincia = provincia1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProvinciaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaisComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
