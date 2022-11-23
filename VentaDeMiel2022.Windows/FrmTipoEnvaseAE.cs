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

namespace VentaDeMiel2022.Windows
{
    public partial class FrmTipoEnvaseAE : Form
    {
        public FrmTipoEnvaseAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoEnvase != null)
            {
                TipoEnvaseTextBox.Text = tipoEnvase.Descripcion;
            }
        }

        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoEnvase == null)
                {
                    tipoEnvase = new TipoEnvase();
                }

                tipoEnvase.Descripcion = TipoEnvaseTextBox.Text;

                DialogResult = DialogResult.OK;

            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TipoEnvaseTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TipoEnvaseTextBox, "El tipo de envase es requerido");
            }

            return valido;
        }
        public void SetTipo(TipoEnvase tipoEnvase)
        {
            this.tipoEnvase = tipoEnvase;
        }
        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
        private TipoEnvase tipoEnvase;

        public TipoEnvase GetTipo()
        {
            return tipoEnvase;
        }
    }
}
