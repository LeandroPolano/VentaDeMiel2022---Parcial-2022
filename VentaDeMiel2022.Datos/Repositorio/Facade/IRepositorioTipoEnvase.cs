using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Datos.Repositorio.Facade
{
    public interface IRepositorioTipoEnvase
    {
        void Guardar(TipoEnvase tipoEnvase);
        List<TipoEnvase> GetLista();
        void Borrar(int tipoEnvaseId);
        TipoEnvase GetTipoPorId(int id);
        bool Existe(TipoEnvase tipoEnvase);
        bool EstaRelacionado(TipoEnvase tipoEnvase);
    }
}
