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

namespace VentaDeMiel2022.Windows.Helpers
{
    public partial class FrmTiposDeDocumentosAE : Form
    {
        public FrmTiposDeDocumentosAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoDeDocumento != null)
            {
                TipoDeDocumentoTextBox.Text = tipoDeDocumento.Descripcion;
            }
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoDeDocumento == null)
                {
                    tipoDeDocumento = new TipoDeDocumento();
                }

                tipoDeDocumento.Descripcion = TipoDeDocumentoTextBox.Text;

                DialogResult = DialogResult.OK;

            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TipoDeDocumentoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TipoDeDocumentoTextBox, "El tipo de Documento es requerido");
            }

            return valido;
        }
        public void SetTipo(TipoDeDocumento tipodeDocumento)
        {
            this.tipoDeDocumento = tipodeDocumento;
        }


        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
        private TipoDeDocumento tipoDeDocumento;

        public TipoDeDocumento GetTipo()
        {
            return tipoDeDocumento;
        }
        private void FrmTiposDeDocumentosAE_Load(object sender, EventArgs e)
        {

        }
    }
}
