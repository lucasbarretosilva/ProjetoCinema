using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Models;

namespace ProjetoCinema.Data
{
    public class ProjetoCinemaContext : DbContext
    {
        public ProjetoCinemaContext (DbContextOptions<ProjetoCinemaContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoCinema.Models.Filme> Filme { get; set; }

        public DbSet<ProjetoCinema.Models.Sala> Sala { get; set; }

        public DbSet<ProjetoCinema.Models.Sessao> Sessao { get; set; }

        public DbSet<ProjetoCinema.Models.Compra> Compra { get; set; }
    }
}
