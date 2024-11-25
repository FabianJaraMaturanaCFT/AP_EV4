namespace AP_EV4.Models
{
    public class Usuario
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public string Email { get; set; }  
        public string Telefono { get; set; }  
        public int RolId { get; set; }  
        public Rol Rol { get; set; }  
    }
}
