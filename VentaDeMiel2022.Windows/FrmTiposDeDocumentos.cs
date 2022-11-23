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
    public partial class FrmTiposDeDocumentos : Form
    {
        public FrmTiposDeDocumentos()
        {
            InitializeComponent();
        }
        private IServicioTipoDeDocumentos servicio;
        private List<TipoDeDocumento> lista;

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            FrmTiposDeDocumentosAE frm = new FrmTiposDeDocumentosAE() { Text = "Agregar Tipo De Documento" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                TipoDeDocumento p = frm.GetTipo();
                if (!servicio.Existe(p))
                {
                    servicio.Guardar(p);
                    var r = HelperGrid.ConstruirFila(dataGridView1);
                    HelperGrid.SetearFila(r, p);
                    HelperGrid.AgregarFila(dataGridView1, r);
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

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                var r = dataGridView1.SelectedRows[0];
                TipoDeDocumento t = (TipoDeDocumento)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                servicio.Borrar(t.TipoDeDocumentoId);
                HelperGrid.BorrarFila(dataGridView1, r);
                HelperMensaje.Mensaje(TipoMensaje.OK, "Registro Borrado", "Mensaje");


            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");

            }
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dataGridView1.SelectedRows[0];
            TipoDeDocumento t = (TipoDeDocumento)r.Tag;
            TipoDeDocumento tAuxiliar = (TipoDeDocumento)t.Clone();
            FrmTiposDeDocumentosAE frm = new FrmTiposDeDocumentosAE() { Text = "Editar tipo de Documento" };
            frm.SetTipo(t);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                t = frm.GetTipo();
                if (!servicio.Existe(t))
                {
                    servicio.Guardar(t);
                    HelperGrid.SetearFila(r, t);
                    MessageBox.Show("Registro modificado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    HelperGrid.SetearFila(r, tAuxiliar);
                    MessageBox.Show("Registro existente", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, tAuxiliar);
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTiposDeDocumentos_Load(object sender, EventArgs e)
        {
            servicio = new ServicioTipoDeDocumento();
            try
            {
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(dataGridView1, lista);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
