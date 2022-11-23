using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Datos.Repositorio.Facade
{
    public interface IRepositorioVendedor
    {
        void Guardar(Vendedor vendedor);
        List<Vendedor> GetLista(Orden orden);
        void Borrar(int vendedorId);
        Vendedor GetVendedorPorId(int id);
        bool Existe(Vendedor vendedor);
        bool EstaRelacionado(Vendedor vendedor);
    }
}
