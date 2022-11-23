using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Datos.Repositorio
{
    public class RepositorioProvincia:IRepositorioProvincia
    {
        private readonly VentaDeMiel2022DbContext context;

        public RepositorioProvincia(VentaDeMiel2022DbContext ventaDeMiel2022DbContext)
        {
            context = new VentaDeMiel2022DbContext();
        }

        public void Guardar(Provincia provincia)
        {
            try
            {
                if (provincia.NombrePais!=null)
                {
                    context.Paises.Attach(provincia.NombrePais);
                }
                if (provincia.ProvinciaId==0)
                {
                    context.Provincias.Add(provincia);
                }
                else
                {
                    var provinciaInDb = context.Provincias.SingleOrDefault(p => p.ProvinciaId == provincia.ProvinciaId);
                    if (provinciaInDb==null)
                    {
                        throw new Exception("Código de provincia inexistente...");
                    }

                    provinciaInDb.NombreProvincia = provincia.NombreProvincia;
                    provinciaInDb.PaisId = provincia.PaisId;
                   

                    context.Entry(provinciaInDb).State = EntityState.Modified;

                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        
        }

      

        public List<Provincia> GetLista(Pais p, Orden orden = Orden.BD)
        {
            try
            {
                IQueryable<Provincia> query = context.Provincias.Include(p => p.NombrePais);
                if (p != null)
                {
                    query = query.Where(p => p.PaisId == p.PaisId);
                }

                switch (orden)
                {
                    case Orden.BD:
                        break;
                    case Orden.AZ:
                        query = query.OrderBy(p => p.NombreProvincia);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(p => p.NombreProvincia);
                        break;
                  
                    default:
                        throw new ArgumentOutOfRangeException(nameof(orden), orden, null);
                }
                return query
                    .AsNoTracking()
                    .ToList();
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
                var provinciaInDb = context.Provincias.SingleOrDefault(p => p.ProvinciaId == provinciaId);
                if (provinciaInDb == null)
                {
                    throw new Exception("Código de provincia inexistente");
                }

                context.Entry(provinciaInDb).State = EntityState.Deleted;
                context.SaveChanges();
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
                if (provincia.ProvinciaId == 0)
                {
                    return context.Provincias
                        .Any(p => p.NombreProvincia == provincia.NombreProvincia && p.PaisId==provincia.PaisId);
                }
                return context.Provincias.Any(p => p.NombreProvincia == provincia.NombreProvincia &&
                                                  p.PaisId == provincia.PaisId  && p.ProvinciaId!=provincia.ProvinciaId);
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
                return context.Localidades
                    .Any(dt => dt.ProvinciaId == provincia.ProvinciaId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }

   
}
