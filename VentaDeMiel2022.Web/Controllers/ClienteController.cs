using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using VentaDeMiel2022.Entidades.Entidades;
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

        //[HttpPost]
        //public JsonResult GuardarCliente(string objeto)
        //{
        //    object resultado = null;
        //    string mensaje = string.Empty;
        //    try
        //    {
        //        Cliente clienteRecibida = new Cliente();
        //        clienteRecibida = JsonConvert.DeserializeObject<Cliente>(objeto);

        //        mensaje = ValidarCliente(clienteRecibida);
        //        if (mensaje == String.Empty)
        //        {
        //            if (!servicio.Existe(clienteRecibida))
        //            {
        //                servicio.Guardar(clienteRecibida);
        //                resultado = clienteRecibida.ClienteId;
        //                mensaje = "Cliente agregada/editada";
        //            }
        //            else
        //            {
        //                resultado = 0;
        //                mensaje = "Cliente existente!!!";
        //            }
        //        }
        //        else
        //        {
        //            resultado = 0;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        resultado = 0;
        //        mensaje = e.Message;

        //    }

        //    return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        //}

        //private string ValidarCliente(Cliente cliente)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    if (string.IsNullOrEmpty(cliente.Nombre))
        //    {
        //        sb.AppendLine("Nombre de la cliente requerido");
        //    }

        //    if (cliente.TipoDeDocumentoId == 0)
        //    {
        //        sb.AppendLine("Debe seleccionar una cliente");
        //    }
        //    return sb.ToString();
        //}


        //[HttpPost]
        //public JsonResult GuardarCliente(string objeto)
        //{
        //    object resultado = null;
        //    string mensaje = string.Empty;
        //    try
        //    {
        //        Cliente clienteRecibido = new Cliente();
        //        clienteRecibido = JsonConvert.DeserializeObject<Cliente>(objeto);

        //        if (mensaje == String.Empty)
        //        {
        //            if (!servicio.Existe(clienteRecibido))
        //            {
        //                servicio.Guardar(clienteRecibido);
        //                resultado = clienteRecibido.ClienteId;
        //                mensaje = "Cliente agregado/editado";
        //            }
        //            else
        //            {
        //                resultado = 0;
        //                mensaje = "Cliente existente";
        //            }
        //        }
        //        else
        //        {
        //            resultado = 0;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        resultado = 0;
        //        mensaje = e.Message;

        //    }

        //    return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        //}

        [HttpPost]
        public JsonResult GuardarCliente(Cliente clienteRecibida)
        {
            object resultado = null;
            string mensaje = ValidarCliente(clienteRecibida);

            if (mensaje.Length == 0)
            {
                try
                {
                    if (!servicio.Existe(clienteRecibida))
                    {
                        servicio.Guardar(clienteRecibida);
                        resultado = clienteRecibida.ClienteId;
                        mensaje = "Cliente agregada/modificada";
                    }
                    else
                    {
                        resultado = 0;
                        mensaje = "Cliente existente";
                    }

                }
                catch (Exception)
                {

                    resultado = 0;
                    mensaje = "Errores!!!";
                }
            }
            else
            {
                resultado = 0;
            }

            return Json(new {resultado= resultado,mensaje= mensaje }, JsonRequestBehavior.AllowGet);
        }

        private string ValidarCliente(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(cliente.Nombre))
            {
                sb.AppendLine("Nombre del cliente requerido");
            }

            return sb.ToString();
        }


    }
}