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
    public class ServicioProvincia:IServicioProvincia
    {
        private readonly IRepositorioProvincia repositorio;
        private readonly IRepositorioPais repositorioPais;
        private readonly VentaDeMiel2022DbContext context;
        public ServicioProvincia()
        {
            repositorio = new RepositorioProvincia(context);
            repositorioPais = new RepositorioPaises(context);

        }
        public void Guardar(Provincia provincia)
        {
            try
            {
                repositorio.Guardar(provincia);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

       

        public List<Provincia> GetLista(Pais p, Orden orden)
        {
            try
            {
                return repositorio.GetLista(p,orden);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int provinciaId)
        {
            try
            {
                repositorio.Borrar(provinciaId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Provincia GetProvinciaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Provincia provincia)
        {
            try
            {
                return repositorio.Existe(provincia);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Provincia provincia)
        {
            try
            {
                return repositorio.EstaRelacionado(provincia);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Pais p;
        public Orden orden;
        public List<Provincia> GetLista()
        {
            try
            {
                return repositorio.GetLista(p,orden);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
