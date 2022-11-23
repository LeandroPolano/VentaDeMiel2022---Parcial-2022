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
    public partial class FrmVendedores : Form
    {
        public FrmVendedores()
        {
            InitializeComponent();
        }
        private IServicioVendedor servicio;
        private List<Vendedor> lista;
        private IconButton botonOrdenActual;

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmVendedoresAE frm = new FrmVendedoresAE() { Text = "Agregar Vendedor" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Vendedor p = frm.GetTipo();
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

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                var r = DatosDataGridView.SelectedRows[0];
                Vendedor t = (Vendedor)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                servicio.Borrar(t.VendedorId);
                HelperGrid.BorrarFila(DatosDataGridView, r);
                HelperMensaje.Mensaje(TipoMensaje.OK, "Registro Borrado", "Mensaje");


            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");

            }
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Vendedor t = (Vendedor)r.Tag;
            Vendedor tAuxiliar = (Vendedor)t.Clone();
            FrmVendedoresAE frm = new FrmVendedoresAE() { Text = "Editar Vendedor" };
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
                    MessageBox.Show("Vendedor existente", "Error",
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

        //private void OredenarAZPorProductoiconButton_Click(object sender, EventArgs e, Orden orden)
        //{
        //    if (botonOrdenActual != (IconButton)sender)
        //    {
        //        RecargarGrilla(Orden.AZ);
        //    }
        //    else
        //    {
        //        RecargarGrilla(Orden.BD);
        //    }
        //    ManejarColorBotonOrden((IconButton)sender);
        //}
        private void RecargarGrilla(Orden orden)
        {
            try
            {
                lista = servicio.GetLista(orden);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                //MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
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

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVendedores_Load(object sender, EventArgs e)
        {
            servicio = new ServicioVendedor();
            RecargarGrilla(Orden.BD);
           
        }

        //private void RecargarGrilla(Orden orden)
        //{
        //    try
        //    {
        //        lista = servicio.GetLista(orden);
        //        HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
        //    }
        //    catch (Exception exception)
        //    {
        //        Console.WriteLine(exception);
        //        throw;
        //    }
        //}
        private void FiltrariconButton_Click(object sender, EventArgs e)
        {
            //if (FiltrariconButton.BackColor == Color.Transparent)
            //{
            //    FrmBuscarPorPais frm = new FrmBuscarPorPais() { Text = "Seleccione un Pais" };
            //    DialogResult dr = frm.ShowDialog(this);
            //    if (dr == DialogResult.Cancel)
            //    {
            //        return;
            //    }

            //    try
            //    {
            //        Pais p = frm.GetTipo();
            //        lista = servicio.GetLista(p, Orden.BD);
            //        HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            //        FiltrariconButton.BackColor = Color.OrangeRed;
            //    }
            //    catch (Exception exception)
            //    {
            //        HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //    }

            //}
            //else
            //{
            //    lista = servicio.GetLista(null, Orden.BD);
            //    HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            //    FiltrariconButton.BackColor = Color.Transparent;
            //}
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
    }
}
