using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Windows.Helpers
{
    public static class HelperCombos
    {
        public static void CargarDatosComboPais(ref ComboBox combo)
        {
            IServicioPais servicio = new ServicioPaises();
            var lista = servicio.GetLista();
            Pais pDefault = new Pais()
            {
                PaisId = 0,
                NombrePais = "Seleccione un pais"
            };
            lista.Insert(0, pDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "NombrePais";
            combo.ValueMember = "PaisId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboProvincia(ref ComboBox combo, Pais pais = null)
        {
            IServicioProvincia servicio = new ServicioProvincia();
            var lista = servicio.GetLista();
            Provincia tpDefault = new Provincia()
            {
                ProvinciaId = 0,
                NombreProvincia = "Seleccione una Provincia"
            };
            lista.Insert(0, tpDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreProvincia";
            combo.ValueMember = "ProvinciaId";
            combo.SelectedIndex = 0;
        }


       
        public static void CargarDatosComboLocalidad(ref ComboBox combo, Provincia provincia =null)
        {


            IServicioLocalidad servicio = new ServicioLocalidad();
            var lista = servicio.GetLista(provincia,Orden.BD);
            Localidad tpDefault = new Localidad()
            {
                LocalidadId = 0,
                NombreLocalidad = "Seleccione una Localidad"
            };
            lista.Insert(0, tpDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreLocalidad";
            combo.ValueMember = "LocalidadId";
            combo.SelectedIndex = 0;
        }
        public static void CargarDatosComboTipoDocumento(ref ComboBox combo)
        {


            IServicioTipoDeDocumentos servicio = new ServicioTipoDeDocumento();
            var lista = servicio.GetLista();
            TipoDeDocumento tpDefault = new TipoDeDocumento()
            {
                TipoDeDocumentoId = 0,
                Descripcion = "Seleccione un tipo de documento"
            };
            lista.Insert(0, tpDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoDeDocumentoId";
            combo.SelectedIndex = 0;
        }
    }
}
