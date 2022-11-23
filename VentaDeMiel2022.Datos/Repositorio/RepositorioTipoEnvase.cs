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
    public class RepositorioTipoEnvase:IRepositorioTipoEnvase
    {
        private readonly VentaDeMiel2022DbContext context;
        public RepositorioTipoEnvase()
        {
            context = new VentaDeMiel2022DbContext();
        }
        public void Guardar(TipoEnvase tipoEnvase)
        {
            try
            {
                
                if (tipoEnvase.TipoEnvaseId == 0)
                {
                    context.TiposEnvases.Add(tipoEnvase);
                }
                else
                {
                    var tipoEnvaseInDb = context.TiposEnvases.SingleOrDefault(p => p.TipoEnvaseId == tipoEnvase.TipoEnvaseId);
                    if (tipoEnvaseInDb == null)
                    {
                        throw new Exception("Código de Envase inexistente");
                    }

                    tipoEnvaseInDb.Descripcion = tipoEnvase.Descripcion;


                    context.Entry(tipoEnvaseInDb).State = EntityState.Modified;

                }

                context.SaveChanges();
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
                return context.TiposEnvases
                    .AsNoTracking()
                    .ToList();
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
                var teInDb = context.TiposEnvases.SingleOrDefault(t => t
                    .TipoEnvaseId == tipoEnvaseId);
                if (teInDb == null)
                {
                    throw new Exception("Tipo de Envase no encontrado");
                }

                context.Entry(teInDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                //if (e.InnerException!=null && e.InnerException.InnerException.Message.Contains("REFERENCE"))
                //{
                //    throw new Exception("Registro relacionado!!! Baja denegada");
                //}
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
                if (tipoEnvase.TipoEnvaseId == 0)
                {
                    return context.TiposEnvases
                        .Any(tp => tp.Descripcion == tipoEnvase.Descripcion);
                }
                return context.TiposEnvases.Any(tp => tp.Descripcion == tipoEnvase.Descripcion &&
                                                       tp.TipoEnvaseId != tipoEnvase.TipoEnvaseId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoEnvase tipoEnvase)
        {
            //try
            //{
            //    return context.TiposEnvases
            //        .Any(p => p.TipoEnvaseId == tipoEnvase.TipoEnvaseId);
            //}
            //catch (Exception e)
            //{
            //    throw new Exception(e.Message);
            //}
            throw new NotImplementedException();

        }
    }
}
