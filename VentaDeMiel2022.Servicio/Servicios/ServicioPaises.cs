using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Servicio.Servicios
{
    public class ServicioPaises : IServicioPais
    {
        private readonly IRepositorioPais repositorio;
        private readonly VentaDeMiel2022DbContext context;

        public ServicioPaises()
        {
            repositorio = new RepositorioPaises(context);
        }
        void IServicioPais.Guardar(Pais pais)
        {
            try
            {
                repositorio.Guardar(pais);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Pais> GetLista()
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

        public void Borrar(int paisId)
        {
            try
            {
                repositorio.Borrar(paisId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public Pais GetPaisPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Pais pais)
        {
            try
            {
                return repositorio.Existe(pais);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Pais pais)
        {
            try
            {
                return repositorio.EstaRelacionado(pais);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
