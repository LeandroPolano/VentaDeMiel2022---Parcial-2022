using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Servicio.Servicios
{
    public class ServicioTipoEnvase : IServicioTipoEnvase
    {
        private readonly IRepositorioTipoEnvase repositorio;

        public ServicioTipoEnvase()
        {
            repositorio = new RepositorioTipoEnvase();
        }
        public void Guardar(TipoEnvase tipoEnvase)
        {
            try
            {
                repositorio.Guardar(tipoEnvase);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<TipoEnvase> GetLista()
        {
            try
            {
                return repositorio.GetLista();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int tipoEnvaseId)
        {
            try
            {
                repositorio.Borrar(tipoEnvaseId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoEnvase GetTipoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(TipoEnvase tipoEnvase)
        {
            try
            {
                return repositorio.Existe(tipoEnvase);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoEnvase tipoEnvase)
        {
            try
            {
                return repositorio.EstaRelacionado(tipoEnvase);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
