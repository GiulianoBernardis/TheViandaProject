using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.Modelos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Filename=./Viandas.db");
        }

        public DbSet<DetalleReceta> DetallesReceta { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<MateriaPrima> MateriasPrimas { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Vianda> Viandas { get; set; }
    }
}
