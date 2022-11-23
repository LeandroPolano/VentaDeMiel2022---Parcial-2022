using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Servicio.Servicios
{
    public class ServicioVendedor : IServicioVendedor
    {
        private readonly IRepositorioVendedor repositorio;

        public ServicioVendedor()
        {
            repositorio = new RepositorioVendedores();
        }
        public void Guardar(Vendedor vendedor)
        {
            try
            {
                repositorio.Guardar(vendedor);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Vendedor> GetLista(Orden orden)
        {
            try
            {
                return repositorio.GetLista(orden);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int vendedorId)
        {
            try
            {
                repositorio.Borrar(vendedorId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Vendedor GetVendedorPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Vendedor vendedor)
        {
            try
            {
                return repositorio.Existe(vendedor);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Vendedor vendedor)
        {
            try
            {
                return repositorio.EstaRelacionado(vendedor);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
