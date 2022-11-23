using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Datos.Repositorio
{
    public class RepositorioProveedor : IRepositorioProveedor
    {
        private readonly VentaDeMiel2022DbContext context;

        public RepositorioProveedor()
        {
            context = new VentaDeMiel2022DbContext();
        }
        public void Borrar(int proveedorId)
        {
            try
            {
                var ProveedorInDb = context.Proveedores.SingleOrDefault(p => p.ProveedorId == proveedorId);
                if (ProveedorInDb == null)
                {
                    throw new Exception("Código de cliente inexistente");
                }

                context.Entry(ProveedorInDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Proveedor proveedor)
        {
            try
            {
                return context.Proveedores
                    .Any(dt => dt.ProveedorId == proveedor.ProveedorId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Proveedor proveedor)
        {
            try
            {
                if (proveedor.ProveedorId == 0)
                {
                    return context.Proveedores
                        .Any(p => p.NroDocumento == proveedor.NroDocumento);
                }
                return context.Clientes.Any(p => p.Nombre == proveedor.Nombre &&
                                                    p.ClienteId != proveedor.ProveedorId &&
                                                    p.Apellido != proveedor.Apellido);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Proveedor GetProovedorPorId(int id)
        {
            try
            {
                return context.Proveedores.SingleOrDefault(p => p.ProveedorId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Proveedor> GetLista(TipoDeDocumento td, Localidad L, Provincia pr, Pais p)
        {
            try
            {


                return context.Proveedores.Include(p => p.TipoDeDocumento)
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

        public void Guardar(Proveedor proveedor)
        {
            try
            {


                if (proveedor.ProveedorId == 0)
                {
                    context.Proveedores.Add(proveedor);
                }
                else
                {
                    var ProveedorInDb = context.Proveedores.SingleOrDefault(p => p.ProveedorId == proveedor.ProveedorId);
                    if (ProveedorInDb == null)
                    {
                        throw new Exception("Código de Proveedor inexistente");
                    }

                    ProveedorInDb.NombreEstablecimiento = proveedor.NombreEstablecimiento;
                    ProveedorInDb.Nombre = proveedor.Nombre;
                    ProveedorInDb.Apellido = proveedor.Apellido;
                    ProveedorInDb.TipoDeDocumentoId = proveedor.TipoDeDocumentoId;
                    ProveedorInDb.LocalidadId = proveedor.LocalidadId;
                    ProveedorInDb.ProvinciaId = proveedor.ProvinciaId;
                    ProveedorInDb.PaisId = proveedor.PaisId;

                    context.Entry(ProveedorInDb).State = EntityState.Modified;

                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
