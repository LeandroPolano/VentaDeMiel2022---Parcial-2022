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
    public partial class FrmProvincia : Form
    {
        private IServicioProvincia servicio;
        private List<Provincia> lista;
        private IconButton botonOrdenActual;

        public FrmProvincia()
        {
            InitializeComponent();
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmProvinciaAE frm = new FrmProvinciaAE() { Text = "Agregar Provincias" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {       
                return;
            }
            try
            {
                Provincia provincia = frm.GetProvincia();
                if (!servicio.Existe(provincia))
                {
                    servicio.Guardar(provincia);
                    RecargarGrilla(Orden.BD);
                    //DataGridViewRow r = HelperGrid.ConstruirFila(DatosDataGridView);
                    //HelperGrid.SetearFila(r, provincia);
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

        private void FrmProvincia_Load(object sender, EventArgs e)
        {
            servicio = new ServicioProvincia();
            RecargarGrilla(Orden.BD);
        }
        private void RecargarGrilla(Orden orden)
        {
            try
            {
                lista = servicio.GetLista(null, orden);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                //MostrarDatosEnGrilla();
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
            Provincia p = (Provincia)r.Tag;
            DialogResult dr = HelperMensaje.Mensaje($"¿Desea borrar la provincia: {p.NombreProvincia}?",
                "Confirmar Borrado");
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (!servicio.EstaRelacionado(p))
                {
                    servicio.Borrar(p.ProvinciaId);
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
                FrmBuscarPorPais frm = new FrmBuscarPorPais() { Text = "Seleccione un Pais" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                try
                {
                    Pais p = frm.GetTipo();
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
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }
            var r = DatosDataGridView.SelectedRows[0];
            Provincia p = (Provincia) r.Tag;
            Provincia pAuxiliar =(Provincia) p.Clone();

            try
            {
                FrmProvinciaAE frm = new FrmProvinciaAE() {Text = "Editar una Provincia"};
                frm.SetProvincia(p);
                DialogResult dr = frm.ShowDialog(this);
                if (dr==DialogResult.Cancel)
                {
                    return;
                }

                p = frm.GetProvincia();
                if (!servicio.Existe(p))
                {
                    servicio.Guardar(p);
                    HelperGrid.SetearFila(r,p);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Provincia editada", "Mensaje");
                }
                else
                {
                    HelperGrid.SetearFila(r,pAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Provincia existente", "Error");
                }

            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, pAuxiliar);

                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
