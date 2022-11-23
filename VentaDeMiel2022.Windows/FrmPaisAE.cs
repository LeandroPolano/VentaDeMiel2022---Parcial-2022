using System;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmPaisAE : Form
    {
        public FrmPaisAE()
        {
            InitializeComponent();
        }

        private Pais pais;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (pais!=null)
            {
                PaisTextBox.Text = pais.NombrePais;
            }
        }

        public Pais GetTipo()
        {
            return pais;
        }


        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void GuardarIconButton_Click(object sender, EventArgs e)
        {
            if (ValidadDatos())
            {
                if (pais == null)
                {
                    pais = new Pais();
                }

                pais.NombrePais = PaisTextBox.Text;
                DialogResult = DialogResult.OK; 
            }
        }

        private bool ValidadDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(PaisTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(PaisTextBox, "Ingrece un Pais");
            }

            return valido;  
        }

        public void SetTipo(Pais pais)
        {
            this.pais = pais;
        }
    }
}
