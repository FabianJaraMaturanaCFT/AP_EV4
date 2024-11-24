namespace AP_EV4.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre_Rol { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}
