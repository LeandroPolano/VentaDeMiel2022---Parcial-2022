using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Servicio.Servicios.Facades
{
    public interface IServicioProveedor
    {
        void Guardar(Proveedor proveedor);

        List<Proveedor> GetLista(TipoDeDocumento td, Localidad L, Provincia pr, Pais p/*, Orden orden*/);


        void Borrar(int proveedorId);

        Proveedor GetProovedorPorId(int id);

        bool Existe(Proveedor proveedor);
        bool EstaRelacionado(Proveedor proveedor);
    }
}
