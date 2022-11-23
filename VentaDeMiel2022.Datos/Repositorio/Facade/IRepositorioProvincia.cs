using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Datos.Repositorio.Facade
{
    public interface IRepositorioProvincia
    {
        void Guardar( Provincia provincia);

        List<Provincia> GetLista(Pais tp, Orden orden);

        void Borrar(int provinciaId);

        Provincia GetProvinciaPorId(int id);

        bool Existe(Provincia provincia);
        bool EstaRelacionado(Provincia provincia);
    }
}
