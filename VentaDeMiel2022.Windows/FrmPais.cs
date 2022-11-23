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
    public partial class FrmPais : Form
    {
        private IServicioPais servicio;
        private List<Pais> lista;
        public FrmPais()
        {
            InitializeComponent();
        }
        private void FrmPais_Load(object sender, EventArgs e)
        {
            servicio = new ServicioPaises();
            try
            {
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }


        }
       
        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmPaisAE frm = new FrmPaisAE() { Text = "Agregar Paises" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Pais p = frm.GetTipo();
                if (!servicio.Existe(p))
                {
                    servicio.Guardar(p);
                    var r = HelperGrid.ConstruirFila(DatosDataGridView);
                    HelperGrid.SetearFila(r, p);
                    HelperGrid.AgregarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Registro agregado", "Mensaje");
                }
                else
                {
                    MessageBox.Show("Registro existente", "error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Pais p = (Pais) r.Tag;
            Pais pAuxiliar = (Pais)p.Clone();

            FrmPaisAE frm = new FrmPaisAE() {Text = "Editar Pais"};
            frm.SetTipo(p);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                p = frm.GetTipo();
                if (!servicio.Existe(p))
                {
                    servicio.Guardar(p);
                    HelperGrid.SetearFila(r, p);
                    MessageBox.Show("Registro modificado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    HelperGrid.SetearFila(r,pAuxiliar);
                    MessageBox.Show("Registro existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r,pAuxiliar);
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                var r = DatosDataGridView.SelectedRows[0];
                Pais p = (Pais)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                if (!servicio.EstaRelacionado(p))
                {
                    servicio.Borrar(p.PaisId);
                    //DatosDataGridView.Rows.Remove(r);
                    HelperGrid.BorrarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Registro Borrado", "Mensaje");
                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Registro relacionado" + Environment.NewLine +
                                                             "Baja Denegada", "Error");
                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");

            }
        }
        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
