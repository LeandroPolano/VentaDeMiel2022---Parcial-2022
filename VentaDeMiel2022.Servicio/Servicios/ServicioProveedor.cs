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
    public class ServicioProveedor : IServicioProveedor
    {
        private readonly IRepositorioProveedor repositorio;
        private readonly IUnitOfWork unitOfWork;
        private readonly VentaDeMiel2022DbContext context;



        public ServicioProveedor()
        {
            
            repositorio = new RepositorioProveedor();
        }
        public void Borrar(int proveedorId)
        {
            try
            {
                repositorio.Borrar(proveedorId);
                unitOfWork.Save();
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
                return repositorio.EstaRelacionado(proveedor);
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
                return repositorio.Existe(proveedor);
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
                return repositorio.GetLista(td, L, pr, p);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Proveedor GetProovedorPorId(int id)
        {
            throw new NotImplementedException();
        }
        public TipoDeDocumento td;
        public Localidad L;
        public Provincia pr;
        public Pais p;
        public void Guardar(Proveedor proveedor)
        {
            try
            {
                repositorio.Guardar(proveedor);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
