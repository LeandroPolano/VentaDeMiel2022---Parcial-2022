using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Datos.Repositorio.Facade
{
    public interface IRepositorioLocalidad
    {
        void Guardar(Localidad localidad);

        List<Localidad> GetLista(Provincia pr, Orden orden);

        void Borrar(int localidadID);

        Localidad GetLocalidadPorId(int id);

        bool Existe(Localidad localidad);
        bool EstaRelacionado(Localidad localidad);
    }
}
