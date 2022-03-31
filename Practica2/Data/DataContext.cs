using Microsoft.EntityFrameworkCore;
using Practica2.Models;

namespace Practica2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Barrio> Barrios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Municipio>()
            .HasIndex(t => t.Nombre)
            .IsUnique();

            modelBuilder.Entity<Barrio>()
                .HasIndex(t => t.Nombre)
                .IsUnique();
        }

    }
}

