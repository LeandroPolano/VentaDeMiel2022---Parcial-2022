using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Web.Controllers
{
    public class ClienteController : Controller
    {
        private IServicioClientes servicio;

        public ClienteController(ServicioCliente servicio)
        {
            this.servicio = servicio;
        }
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult ListarClientes()
        {
            var lista = servicio.GetLista();
            return Json(new { data = lista}, JsonRequestBehavior.AllowGet);
        }

    }
}