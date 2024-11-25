using Microsoft.EntityFrameworkCore;

namespace AP_EV4.Models
{
    public class Tarea
    {
        public int Id { get; set; } 
        public string Descripcion { get; set; }  
        public string Estado { get; set; }  
        public DateTime FechaInicio { get; set; } 
        public DateTime FechaFin { get; set; }  
        public int ProyectoId { get; set; }  
        public Proyecto Proyecto { get; set; }  
        public int UsuarioId { get; set; }  
        public Usuario Usuario { get; set; }

        //SOLUCION PARA EVITAR ELIMINACIONES EN CASCADA
        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarea>()
                .HasOne(t => t.Usuario)
                .WithMany()
                .HasForeignKey(t => t.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Tarea>()
                .HasOne(t => t.Proyecto)
                .WithMany()
                .HasForeignKey(t => t.ProyectoId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
