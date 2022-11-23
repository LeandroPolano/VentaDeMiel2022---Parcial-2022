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
    public partial class FrmProveedoresAE : Form
    {
        public FrmProveedoresAE()
        {
            InitializeComponent();
        }
        private IServicioProveedor servicio;

        private Proveedor proveedor;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioProveedor();
            HelperCombos.CargarDatosComboTipoDocumento(ref TipoDeDocumentoComboBox);
            HelperCombos.CargarDatosComboLocalidad(ref LocalidadComboBox);
            HelperCombos.CargarDatosComboProvincia(ref ProvinciaComboBox);
            HelperCombos.CargarDatosComboPais(ref PaisComboBox);

            if (proveedor != null)
            {
                NombreEstablecimientoTextBox.Text = proveedor.NombreEstablecimiento;
                NombreTextBox.Text = proveedor.Nombre;
                ApellidoTextBox.Text = proveedor.Apellido;
                TipoDeDocumentoComboBox.SelectedValue = proveedor.TipoDeDocumentoId;
                NroDocumentoTextBox.Text = proveedor.NroDocumento;
                DireccionTextBox.Text = proveedor.Direccion;
                LocalidadComboBox.SelectedValue = proveedor.LocalidadId;
                ProvinciaComboBox.SelectedValue = proveedor.ProvinciaId;
                PaisComboBox.SelectedValue = proveedor.PaisId;
                TelefonoFijoTextBox.Text = proveedor.TelefonoFijo;
                TelefonoMovilTextBox.Text = proveedor.TelefonoMovil;
                CorreoElectronicoTextBox.Text = proveedor.CorreoElectronico;


            }

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal void SetProveedor(Proveedor proveedor1)
        {
            this.proveedor = proveedor1;
        }

        internal Proveedor GetProveedor()
        {
            return proveedor;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                if (ValidarDatos())
                {

                    if (proveedor == null)
                    {
                        proveedor = new Proveedor();
                    }

                    proveedor.NombreEstablecimiento = NombreEstablecimientoTextBox.Text;
                    proveedor.Nombre = NombreTextBox.Text;
                    proveedor.Apellido = ApellidoTextBox.Text;
                    proveedor.TipoDeDocumentoId = ((TipoDeDocumento)TipoDeDocumentoComboBox.SelectedItem).TipoDeDocumentoId;
                    //cliente.TipoDeDocumento = (TipoDeDocumento)TipoDeDocumentoComboBox.SelectedItem;
                    proveedor.NroDocumento = NroDocumentoTextBox.Text;
                    proveedor.Direccion = DireccionTextBox.Text;
                    proveedor.LocalidadId = ((Localidad)LocalidadComboBox.SelectedItem).LocalidadId;
                    //cliente.Localidad = (Localidad)LocalidadComboBox.SelectedItem;
                    proveedor.ProvinciaId = ((Provincia)ProvinciaComboBox.SelectedItem).ProvinciaId;
                    //cliente.Provincia = (Provincia)ProvinciaComboBox.SelectedItem;
                    proveedor.PaisId = ((Pais)PaisComboBox.SelectedItem).PaisId;
                    //cliente.Pais = (Pais)PaisComboBox.SelectedItem;
                    proveedor.TelefonoFijo = TelefonoFijoTextBox.Text;
                    proveedor.TelefonoMovil = TelefonoMovilTextBox.Text;
                    proveedor.CorreoElectronico = CorreoElectronicoTextBox.Text;


                    DialogResult = DialogResult.OK;

                }
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(NombreTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(NombreTextBox, "El Nombre es requerido");
            }
            if (string.IsNullOrEmpty(ApellidoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ApellidoTextBox, "El Apellido es requerido");
            }
            if (string.IsNullOrEmpty(NroDocumentoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(NroDocumentoTextBox, "El Numero de documento es requerido");
            }
            if (string.IsNullOrEmpty(DireccionTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(DireccionTextBox, "La Direccion es requerida");
            }


            if (TipoDeDocumentoComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TipoDeDocumentoComboBox, "Debe seleccionar un Tipo De Documento");
            }
            if (LocalidadComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(LocalidadComboBox, "Debe seleccionar una localidad");
            }
            if (ProvinciaComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ProvinciaComboBox, "Debe seleccionar una provincia");
            }
            if (PaisComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PaisComboBox, "Debe seleccionar un pais");
            }

            return valido;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
