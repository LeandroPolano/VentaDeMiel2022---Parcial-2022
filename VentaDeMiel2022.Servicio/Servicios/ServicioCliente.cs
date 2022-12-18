using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Servicio.Servicios
{
    public class ServicioCliente:IServicioClientes
    {
        private readonly IRepositorioCliente repositorio;

        public ServicioCliente()
        {
            repositorio = new RepositorioClientes();
        }
        public void Guardar(Cliente cliente)
        {
            try
            {
                repositorio.Guardar(cliente);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoDeDocumento td;
        public Localidad L;
        public Provincia pr;
        public Pais p;
        public Orden orden;
        public List<Cliente> GetLista(TipoDeDocumento td, Localidad L, Provincia pr, Pais p)
        {
            try
            {
                return repositorio.GetLista(td,L,pr,p);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int clienteId)
        {
            try
            {
                repositorio.Borrar(clienteId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Cliente GetClientePorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Cliente cliente)
        {
            try
            {
                return repositorio.Existe(cliente);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Cliente cliente)
        {
            try
            {
                return repositorio.EstaRelacionado(cliente);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public List<Entidades.Dtos.Cliente.ClienteListDto> GetLista2()
        //{
        //    try
        //    {
        //        return repositorio.GetLista2();
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}
    }
}
