using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Servicio.Servicios.Facades
{
    public interface IServicioProvincia
    {
        void Guardar(Provincia provincia);

        List<Provincia> GetLista(Pais tp, Orden orden);

        void Borrar(int provinciaId);

        Provincia GetProvinciaPorId(int id);

        bool Existe(Provincia provincia);
        bool EstaRelacionado(Provincia provincia);

        List<Provincia> GetLista();
    }
}
