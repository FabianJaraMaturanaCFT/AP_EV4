﻿using AP_EV4.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace AP_EV4.Data
{
    public class DBContext
    {
        public class EjemploDbContext : DbContext
        {
            public EjemploDbContext(DbContextOptions<EjemploDbContext> options) : base(options)
            {
            }

            /* DbSet indica el modelo que se va a mapear (reflejar) a la base de datos */
            public DbSet<Rol> Roles { get; set; }

            public DbSet<Usuario> Usuarios { get; set; }

            public DbSet<Proyecto> Proyectos { get; set; }

            public DbSet<Log> Log { get; set; }

            public DbSet<Cliente> Clientes { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                //Acá se pueden cargar los datos iniciales de la base de datos

                modelBuilder.Entity<Rol>().HasData(new Rol
                {
                    Id = 1,
                    Nombre_Rol = "Agente"
                });

                modelBuilder.Entity<Rol>().HasData(new Rol
                {
                    Id = 2,
                    Nombre_Rol = "Supervisor"
                });

            }

        }

    }
}
