using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;
using VentaDeMiel2022.Windows.Helpers;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmLocalidades : Form
    {
        public FrmLocalidades()
        {
            InitializeComponent();
        }
        private IServicioLocalidad servicio;
        private List<Localidad> lista;
        private IconButton botonOrdenActual;

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmLocalidadAE frm = new FrmLocalidadAE() { Text = "Agregar Localidades" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Localidad localidad = frm.GetLocalidad();
                if (!servicio.Existe(localidad))
                {
                    servicio.Guardar(localidad);
                    RecargarGrilla(Orden.BD);
                    //DataGridViewRow r = HelperGrid.ConstruirFila(DatosDataGridView);
                    //HelperGrid.SetearFila(r, localidad);
                    //HelperGrid.AgregarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Registro agregado", "Mensaje");
                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Registro repetido!!", "Error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLocalidades_Load(object sender, EventArgs e)
        {
            servicio = new ServicioLocalidad();
            RecargarGrilla(Orden.BD);
        }
        private void RecargarGrilla(Orden orden)
        {
            try
            {
                lista = servicio.GetLista(null, orden);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Localidad p = (Localidad)r.Tag;
            DialogResult dr = HelperMensaje.Mensaje($"¿Desea borrar la Localidad: {p.NombreLocalidad}?",
                "Confirmar Borrado");
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (!servicio.EstaRelacionado(p))
                {
                    servicio.Borrar(p.LocalidadId);
                    HelperGrid.BorrarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Registro eliminado",
                        "Mensaje");
                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Registro relacionado" + Environment.NewLine + "Baja denegada",
                        "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message,
                    "Error");
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FiltrariconButton_Click(object sender, EventArgs e)
        {
            if (FiltrariconButton.BackColor == Color.Transparent)
            {
                FrmBuscarPorProvincia frm = new FrmBuscarPorProvincia() { Text = "Seleccione una provincia" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                try
                {
                    Provincia p = frm.GetTipo();
                    lista = servicio.GetLista(p, Orden.BD);
                    HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                    FiltrariconButton.BackColor = Color.OrangeRed;
                }
                catch (Exception exception)
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
                }

            }
            else
            {
                lista = servicio.GetLista(null, Orden.BD);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                FiltrariconButton.BackColor = Color.Transparent;
            }

        }

        private void OredenarAZPorProductoiconButton_Click(object sender, EventArgs e)
        {
            if (botonOrdenActual != (IconButton)sender)
            {
                RecargarGrilla(Orden.AZ);
            }
            else
            {
                RecargarGrilla(Orden.BD);
            }
            ManejarColorBotonOrden((IconButton)sender);
        }
        private void ManejarColorBotonOrden(IconButton sender)
        {
            if (botonOrdenActual == null)
            {
                botonOrdenActual = sender;
                botonOrdenActual.BackColor = Color.OrangeRed;
            }
            else
            {
                if (botonOrdenActual == sender)
                {
                    botonOrdenActual = null;
                    sender.BackColor = Color.Transparent;
                }
                else
                {
                    botonOrdenActual.BackColor = Color.Transparent;
                    botonOrdenActual = sender;
                    botonOrdenActual.BackColor = Color.OrangeRed;
                }
            }
        }
        private void PrecioDescIconButton_Click(object sender, EventArgs e)
        {
            if (botonOrdenActual != (IconButton)sender)
            {
                RecargarGrilla(Orden.ZA);

            }
            else
            {
                RecargarGrilla(Orden.BD);
            }
            ManejarColorBotonOrden((IconButton)sender);
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosDataGridView.SelectedRows[0];
            Localidad l = (Localidad)r.Tag;
            Localidad lAuxiliar = (Localidad)l.Clone();

            try
            {
                FrmLocalidadAE frm = new FrmLocalidadAE() { Text = "Editar una Localidad" };
                frm.SetLocalidad(l);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                l = frm.GetLocalidad();
                if (!servicio.Existe(l))
                {
                    servicio.Guardar(l);
                    HelperGrid.SetearFila(r, l);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Localidad editada", "Mensaje");
                }
                else
                {
                    HelperGrid.SetearFila(r, lAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Localidad existente", "Error");
                }

            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, lAuxiliar);

                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void CerrarButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
