namespace AP_EV4.Models
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }  
        public string Descripcion { get; set; }  
        public DateTime FechaInicio { get; set; } 
        public DateTime FechaFin { get; set; }  
        public int ClienteId { get; set; }  
        public Cliente Cliente { get; set; }  
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public bool Revisado { get; set; }

    }
}
