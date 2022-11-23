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
    public partial class FrmLocalidadAE : Form
    {
        public FrmLocalidadAE()
        {
            InitializeComponent();
        }
        private IServicioProvincia servicio;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioProvincia();
            HelperCombos.CargarDatosComboProvincia(ref ProvinciaComboBox);
            if (localidad != null)
            {
                LocalidadTextBox.Text = localidad.NombreLocalidad;

                ProvinciaComboBox.SelectedValue = localidad.ProvinciaId;

            }

        }
        

        private Localidad localidad;
        public Localidad GetLocalidad()
        {
            return localidad;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (ValidarDatos())
                {
                    if (localidad == null)
                    {
                        localidad = new Localidad();
                    }

                    localidad.NombreLocalidad = LocalidadTextBox.Text;
                    localidad.ProvinciaId = ((Provincia)ProvinciaComboBox.SelectedItem).ProvinciaId;
                    localidad.NombreProvincia = (Provincia)ProvinciaComboBox.SelectedItem;




                    DialogResult = DialogResult.OK;
                }
            }

        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(LocalidadTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(LocalidadTextBox, "La localidad es requerida");
            }
            if (ProvinciaComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ProvinciaComboBox, "Debe seleccionar una provincia");
            }

            return valido;
        }
        
        private void FrmLocalidadAE_Load(object sender, EventArgs e)
        {
            
        }

        public void SetLocalidad(Localidad localidad)
        {
            this.localidad = localidad;
        }
    }
}
