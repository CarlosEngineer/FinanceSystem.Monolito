using Finance.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Infra.FinanceDbContext
{
    public class FinaDbContext : DbContext
    {
        public FinaDbContext(DbContextOptions<FinaDbContext> options) : base (options) 
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Saida> Saidas { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Entrada>()
                .HasOne(u => u.Usuario)
                .WithMany(e => e.Entrada)
                .HasForeignKey(u => u.UsuarioId);

            mb.Entity<Saida>()
                .HasOne(u => u.Usuario)
                .WithMany(e => e.Saida)
                .HasForeignKey(u => u.UsuarioId);
        }
    }
}
