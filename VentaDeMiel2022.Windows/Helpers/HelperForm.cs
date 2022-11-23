using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Windows.Helpers
{
    public static class HelperForm 
    {
        public static void MostrarDatosEnGrilla<P>(DataGridView dataGridView, List<P> objList)
        {
            //DatosDataGridView.Rows.Clear();
            HelperGrid.LimpiarGrilla(dataGridView);
            foreach (var obj in objList)
            {
                //var r = ConstruirFila();
                var r = HelperGrid.ConstruirFila(dataGridView);
                HelperGrid.SetearFila(r, obj);
                HelperGrid.AgregarFila(dataGridView, r);
            }
        }

        internal static void MostrarDatosEnGrilla(object datosDataGridView, List<Proveedor> lista)
        {
            throw new NotImplementedException();
        }
    }
}
