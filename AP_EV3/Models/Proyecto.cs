namespace AP_EV4.Models
{
    public class Proyecto
    {
        public string Id { get; set; }
        public string NombreProyecto { get; set; }
        public string Descripcion { get; set; }
        public int Cliente_proyecto { get; set; }
        public Cliente Usuario { get; set; }
        public DateTime FechaDeCreacion { get; set; }

    }
}
