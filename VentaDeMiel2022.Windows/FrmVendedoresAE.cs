using System;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmVendedoresAE : Form
    {
        public FrmVendedoresAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (vendedor != null)
            {
                NombreTextBox.Text = vendedor.Nombre;
                ApellidoTextBox.Text = vendedor.Apellido;
                SexoTextBox.Text = vendedor.Sexo;
                FechaDeNacimientoDateTimePicker.Value =vendedor.FechaNacimiento.Date;
                NroDocumentoTextBox.Text = vendedor.NroDocumento;
                DireccionTextBox.Text = vendedor.Direccion;
                TelefonoFijoTextBox.Text = vendedor.TelefonoFijo;
                TelefonoMovilTextBox.Text = vendedor.TelefonoMovil;
                CorreoElectronicoTextBox.Text = vendedor.Correo;
                UsuarioTextBox.Text = vendedor.Usuario;
                ContraseñaTextBox.Text = vendedor.Contraseña;
            }
        }
        private Vendedor vendedor;
        public Vendedor GetTipo()
        {
            return vendedor;
        }

        public void SetTipo(Vendedor vendedor1)
        {
            this.vendedor = vendedor1;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (vendedor == null)
                {
                    vendedor = new Vendedor();
                }

                vendedor.Nombre = NombreTextBox.Text;
                vendedor.Apellido = ApellidoTextBox.Text;
                vendedor.Sexo = SexoTextBox.Text;
                vendedor.FechaNacimiento =FechaDeNacimientoDateTimePicker.Value;
                vendedor.NroDocumento = NroDocumentoTextBox.Text;
                vendedor.Direccion = DireccionTextBox.Text;
                vendedor.TelefonoFijo = TelefonoFijoTextBox.Text;
                vendedor.TelefonoMovil = TelefonoMovilTextBox.Text;
                vendedor.Correo = CorreoElectronicoTextBox.Text;
                vendedor.Usuario = UsuarioTextBox.Text;
                vendedor.Contraseña = ContraseñaTextBox.Text;
                
                
                

                DialogResult = DialogResult.OK;

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
            if (string.IsNullOrEmpty(SexoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(SexoTextBox, "El Sexo es requerido");
            }
            if (string.IsNullOrEmpty(FechaDeNacimientoDateTimePicker.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(FechaDeNacimientoDateTimePicker, "La Fecha de nacimiento es requerida");
            }
            if (string.IsNullOrEmpty(NroDocumentoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(NroDocumentoTextBox, "El Numero de documento es requerido");
            }
            if (string.IsNullOrEmpty(DireccionTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(DireccionTextBox, "La direccion es requerida");
            }
            //if (string.IsNullOrEmpty(TelefonoFijoTextBox.Text.Trim()))
            //{
            //    valido = false;
            //    errorProvider1.SetError(TelefonoFijoTextBox, "El Telefono Fijo es requerido");
            //}
            //if (string.IsNullOrEmpty(TelefonoMovilTextBox.Text.Trim()))
            //{
            //    valido = false;
            //    errorProvider1.SetError(TelefonoMovilTextBox, "El Telefono Movil es requerido");
            //}
            //if (string.IsNullOrEmpty(CorreoElectronicoTextBox.Text.Trim()))
            //{
            //    valido = false;
            //    errorProvider1.SetError(CorreoElectronicoTextBox, "El Correo es requerido");
            //}
            if (string.IsNullOrEmpty(UsuarioTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(UsuarioTextBox, "El Usuario es requerido");
            }
            if (string.IsNullOrEmpty(ContraseñaTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ContraseñaTextBox, "La Contraseña es requerida");
            }

            return valido;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmVendedoresAE_Load(object sender, EventArgs e)
        {

        }
    }
}
