using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Datos.Repositorio
{
    public class RepositorioVendedores : IRepositorioVendedor
    {
        private readonly VentaDeMiel2022DbContext context;
        public RepositorioVendedores()
        {
            context = new VentaDeMiel2022DbContext();
        }
        public void Guardar(Vendedor vendedor)
        {
            try
            {

                if (vendedor.VendedorId == 0)
                {
                    context.Vendedores.Add(vendedor);
                }
                else
                {
                    var vendedorInDb = context.Vendedores.SingleOrDefault(p => p.VendedorId == vendedor.VendedorId);
                    if (vendedorInDb == null)
                    {
                        throw new Exception("Código de vendedor inexistente");
                    }

                    vendedorInDb.Nombre = vendedor.Nombre;
                    vendedorInDb.Apellido = vendedor.Apellido;
                    vendedorInDb.NroDocumento = vendedor.NroDocumento;

                    context.Entry(vendedorInDb).State = EntityState.Modified;

                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Vendedor> GetLista(Orden orden = Orden.BD)
        {
            try
            {
               
                return context.Vendedores
                    .AsNoTracking()
                    .ToList();




                //switch (orden)
                //{
                //    case Orden.BD:
                //        break;
                //    case Orden.AZ:
                //        query = query.OrderBy(p => p.Nombre);
                //        break;
                //    case Orden.ZA:
                //        query = query.OrderByDescending(p => p.Nombre);
                //        break;

                //    default:
                //        throw new ArgumentOutOfRangeException(nameof(orden), orden, null);
                //}
                //return query
                //    .AsNoTracking()
                //    .ToList();

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
                var tdInDb = context.Vendedores.SingleOrDefault(t => t
                    .VendedorId == vendedorId);
                if (tdInDb == null)
                {
                    throw new Exception("Vendedor no encontrado");
                }

                context.Entry(tdInDb).State = EntityState.Deleted;
                context.SaveChanges();
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
                if (vendedor.VendedorId == 0)
                {
                    return context.Vendedores
                        .Any(tp => tp.NroDocumento == vendedor.NroDocumento);
                }
                return context.Vendedores.Any(tp => tp.VendedorId == vendedor.VendedorId &&
                                                    tp.NroDocumento != vendedor.NroDocumento);
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
                if (context.DetalleVentas.Any(p => p.VendedorId == vendedor.VendedorId))
                {
                    return context.DetalleVentas.Any();

                }
               

                return false;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
