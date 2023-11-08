using ClubDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDesktop.Data
{
    public class ClubDesktopContext : DbContext
    {
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Cobrador> Cobradores { get; set; }
        public DbSet<Cuota> Cuotas { get; set; }

        public ClubDesktopContext()
        {
            
        }

        public ClubDesktopContext(DbContextOptions<ClubDesktopContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cadenaConexion = "Server=.\\SQLEXPRESS ; User Id=sa ; Password=123 ; Database=ClubDesktopContext; MultipleActiveResultSets = True; Encrypt=False ";
           optionsBuilder.UseSqlServer(cadenaConexion);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //creamos los datos semilla para socios
            modelBuilder.Entity<Socio>().HasData(
                new Socio { Id = 1, ApellidoNombre = "Juan Perez", Dirección = "9 de julio 2323", Teléfono = "123456" },
                new Socio { Id = 2, ApellidoNombre = "Fulano DeTal", Dirección = "Av Iriondo 2123", Teléfono = "345678" }
                );

            modelBuilder.Entity<Actividad>().HasData(
                new Actividad { Id= 1, Nombre="Ajedrez", Costo=2500, Horarios="Lunes y miércoles 20hs"},
                new Actividad { Id = 2, Nombre = "Folklore", Costo = 2000, Horarios = "Martes y Jueves 20hs" }
                );

            modelBuilder.Entity<Cobrador>().HasData(new Cobrador { Id = 1, Nombre="Oscar Rodriguez" });
        }
    }
}
