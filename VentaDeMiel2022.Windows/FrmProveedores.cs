using FontAwesome.Sharp;
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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private IServicioProveedor servicio;
        private List<Proveedor> lista;
        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmProveedoresAE frm = new FrmProveedoresAE() { Text = "Proveedores" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Proveedor proveedor = frm.GetProveedor();
                if (!servicio.Existe(proveedor))
                {
                    servicio.Guardar(proveedor);
                    RecargarGrilla();

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
        public TipoDeDocumento td;
        public Localidad L;
        public Provincia pr;
        public Pais p;
      
        private void RecargarGrilla(/*TipoDeDocumento td, Localidad L, Provincia pr, Pais p*/)
        {
            try
            {
                lista = servicio.GetLista(td, L, pr, p);
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
            Proveedor p = (Proveedor)r.Tag;
            DialogResult dr = HelperMensaje.Mensaje($"¿Desea borrar el proveedor: {p.Nombre} {p.Apellido} Documento: {p.NroDocumento}?",
                "Confirmar Borrado");
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (servicio.EstaRelacionado(p))
                {
                    servicio.Borrar(p.ProveedorId);
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

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosDataGridView.SelectedRows[0];
            Proveedor l = (Proveedor)r.Tag;
            Proveedor lAuxiliar = (Proveedor)l.Clone();

            try
            {
                FrmProveedoresAE frm = new FrmProveedoresAE() { Text = "Editar un proovedor" };
                frm.SetProveedor(l);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                l = frm.GetProveedor();
                if (!servicio.Existe(l))
                {
                    servicio.Guardar(l);
                    HelperGrid.SetearFila(r, l);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "proovedor editado", "Mensaje");
                }
                else
                {
                    HelperGrid.SetearFila(r, lAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.Error, "proovedor existente", "Error");
                }

            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, lAuxiliar);

                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            servicio = new ServicioProveedor();
            RecargarGrilla(/*td,L,pr,p*/);
            
        }
    }
}
