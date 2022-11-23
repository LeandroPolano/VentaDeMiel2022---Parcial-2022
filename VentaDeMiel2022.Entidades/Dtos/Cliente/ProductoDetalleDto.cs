namespace VentaDeMiel2022.Entidades.Dtos.Producto
{
    public class ClienteDetalleDto
    {
        public int ClienteId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int TipoDeDocumentoId { get; set; }
        public string NroDocumento { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string CorreoElectronico { get; set; }


    }
}