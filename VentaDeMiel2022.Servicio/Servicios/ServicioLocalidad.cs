using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Servicio.Servicios
{
    public class ServicioLocalidad:IServicioLocalidad
    {
        private readonly IRepositorioLocalidad repositorio;
        private readonly IRepositorioProvincia repositorioProvincia;
        private readonly VentaDeMiel2022DbContext context;
        public ServicioLocalidad()
        {
            context = new VentaDeMiel2022DbContext();
            repositorio = new RepositorioLocalidades(context);
            repositorioProvincia = new RepositorioProvincia(context);
        }
        public void Guardar(Localidad localidad)
        {
            try
            {
                repositorio.Guardar(localidad);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Localidad> GetLista(Provincia pr, Orden orden)
        {
            try
            {
                return repositorio.GetLista(pr, orden);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int localidadID)
        {
            try
            {
                repositorio.Borrar(localidadID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Localidad GetLocalidadPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Localidad localidad)
        {
            try
            {
                return repositorio.Existe(localidad);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Localidad localidad)
        {
            try
            {
                return repositorio.EstaRelacionado(localidad);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

      

        public Provincia pr;
        public Orden orden;
        public List<Localidad> GetLista()
        {
            try
            {
                return repositorio.GetLista(pr, orden);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
