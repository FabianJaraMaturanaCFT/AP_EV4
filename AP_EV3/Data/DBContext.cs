using AP_EV4.Models;
using Microsoft.EntityFrameworkCore;

namespace AP_EV4.Data
{
    public class EjemploDbContext : DbContext
    {
        public EjemploDbContext(DbContextOptions<EjemploDbContext> options) : base(options)
        {
        }

        /* DbSet indica el modelo que se va a mapear (reflejar) a la base de datos */
        public DbSet<Cliente> Clientes { get; set; }  
        public DbSet<Proyecto> Proyectos { get; set; }  
        public DbSet<Usuario> Usuarios { get; set; }  
        public DbSet<Rol> Roles { get; set; }  
        public DbSet<Tarea> Tareas { get; set; }  
        public DbSet<Log> Logs { get; set; }  


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Tarea.Configure(modelBuilder);

            //Acá se pueden cargar los datos iniciales de la base de datos

            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                Id = 1,
                Nombre = "Agente"
            });

            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                Id = 2,
                Nombre = "Administrador"
            });

            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                Id = 3,
                Nombre = "Supervisor"
            });

            modelBuilder.Entity<Rol>().HasData(new Rol
            {
                Id = 4,
                Nombre = "Empleado"
            });

        }

    }

}
