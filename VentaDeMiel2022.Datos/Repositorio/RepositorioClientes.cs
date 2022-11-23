using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Dtos.Cliente;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Datos.Repositorio
{
    public class RepositorioClientes: IRepositorioCliente
    {
        private readonly VentaDeMiel2022DbContext context;

        public RepositorioClientes()
        {
            context = new VentaDeMiel2022DbContext();
        }
        public void Guardar(Entidades.Entidades.Cliente cliente)
        {
            try
            {

                
                if (cliente.ClienteId == 0)
                {
                    context.Clientes.Add(cliente);
                }
                else
                {
                    var ClientesInDb = context.Clientes.SingleOrDefault(p => p.ClienteId == cliente.ClienteId);
                    if (ClientesInDb == null)
                    {
                        throw new Exception("Código de Cliente inexistente");
                    }

                    ClientesInDb.Nombre = cliente.Nombre;
                    ClientesInDb.Apellido = cliente.Apellido;
                    ClientesInDb.TipoDeDocumentoId = cliente.TipoDeDocumentoId;
                    ClientesInDb.LocalidadId = cliente.LocalidadId;
                    ClientesInDb.ProvinciaId = cliente.ProvinciaId; 
                    ClientesInDb.PaisId = cliente.PaisId;

                    context.Entry(ClientesInDb).State = EntityState.Modified;

                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Entidades.Entidades.Cliente> GetLista(TipoDeDocumento td = null, Localidad L= null, Provincia pr= null, Pais p=null)
        {
            try
            {


                return context.Clientes.Include(p => p.TipoDeDocumento)
                    .Include(p => p.Localidad)
                    .Include(p => p.Provincia)
                    .Include(p => p.Pais)
                    .AsNoTracking().ToList();


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
                var ClienteInDb = context.Clientes.SingleOrDefault(p => p.ClienteId == clienteId);
                if (ClienteInDb == null)
                {
                    throw new Exception("Código de cliente inexistente");
                }

                context.Entry(ClienteInDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Cliente GetClientePorId(int id)
        {
            try
            {
                return context.Clientes.SingleOrDefault(p => p.ClienteId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Cliente cliente)
        {
            try
            {
                if (cliente.ClienteId == 0)
                {
                    return context.Clientes
                        .Any(p => p.NroDocumento == cliente.NroDocumento);
                }
                return context.Clientes.Any(p => p.Nombre == cliente.Nombre &&
                                                    p.ClienteId != cliente.ClienteId &&
                                                    p.Apellido != cliente.Apellido);
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
                return context.Clientes
                    .Any(dt => dt.ClienteId == cliente.ClienteId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<ClienteListDto> GetLista2()
        {
            try
            {
                return context.Clientes
                    .Include(c => c.TipoDeDocumento)
                    .Include(c => c.Pais)
                    .Include(c => c.Provincia)
                    .Include(c => c.Localidad)
                    .Select(c => new ClienteListDto()
                    {
                        ClienteId = c.ClienteId,
                        Nombre = c.Nombre,
                        Apellido = c.Apellido,
                        TipoDeDocumento = c.TipoDeDocumento.Descripcion,
                        NroDocumento = c.NroDocumento,
                        Direccion = c.Direccion,
                        Localidad = c.Localidad.NombreLocalidad,
                        Provincia = c.Provincia.NombreProvincia,
                        Pais = c.Pais.NombrePais,
                        TelefonoFijo = c.TelefonoFijo,
                        TelefonoMovil = c.TelefonoMovil,
                        CorreoElectronico = c.CorreoElectronico

                    }).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
