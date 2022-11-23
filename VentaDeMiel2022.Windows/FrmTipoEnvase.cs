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
    public partial class FrmTipoEnvase : Form
    {
        public FrmTipoEnvase()
        {
            InitializeComponent();
        }
        private IServicioTipoEnvase servicio;
        private List<TipoEnvase> lista;
        private void TipoEnvase_Load(object sender, EventArgs e)
        {
            servicio = new ServicioTipoEnvase();
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
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            FrmTipoEnvaseAE frm = new FrmTipoEnvaseAE() { Text = "Agregar TipoEnvases" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                TipoEnvase p = frm.GetTipo();
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



        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
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
                TipoEnvase t = (TipoEnvase)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }
                
                servicio.Borrar(t.TipoEnvaseId);
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
            TipoEnvase t = (TipoEnvase)r.Tag;
            TipoEnvase tAuxiliar = (TipoEnvase)t.Clone();
            FrmTipoEnvaseAE frm = new FrmTipoEnvaseAE() { Text = "Editar tipo de Envase" };
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
    }
}
