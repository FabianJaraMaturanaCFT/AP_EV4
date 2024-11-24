namespace AP_EV4.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public Rol Rol { get; set; }
        public int RolId { get; set; }
        public string correo { get; set; }
        public string Contrasenia { get; set; }
    }
}
