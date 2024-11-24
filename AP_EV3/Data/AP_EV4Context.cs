using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AP_EV4.Models;

namespace AP_EV4.Data
{
    public class AP_EV4Context : DbContext
    {
        public AP_EV4Context (DbContextOptions<AP_EV4Context> options)
            : base(options)
        {
        }

        public DbSet<AP_EV4.Models.Proyecto> Proyecto { get; set; } = default!;

        public DbSet<AP_EV4.Models.Log>? Log { get; set; }

        public DbSet<AP_EV4.Models.Usuario>? Usuario { get; set; }

        public DbSet<AP_EV4.Models.Rol>? Rol { get; set; }

        public DbSet<AP_EV4.Models.Cliente>? Cliente { get; set; }
    }
}
