using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPrograIIIB.Models
{
    public class ProductsContext : DbContext //Representa un contexto de base de datos
    {
        public DbSet<Product> Products { get; set;} //dbset es una entidad o tabla
        public DbSet<Category> Categories { get; set;}
        //OnConfiguring

        //Crear la base de datos o la va a asignar para su uso
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");
        //Creacion de filas en la base de datos por derecto
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //inserts de prueba
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Queso" },
                new Category { CategoryId = 2, Name = "Carne" },
                new Category { CategoryId = 3, Name = "Pezcado" },
                new Category { CategoryId = 4, Name = "Pan" },
                new Category { CategoryId = 5, Name = "Pizza" }
                );

            //insert de productos

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductIt = 1, Name = "Cheddar", CategoryId= 1 },
                new Product { ProductIt = 2, Name = "Brie", CategoryId= 1 },
                new Product { ProductIt = 3, Name = "Stilton", CategoryId= 1 },
                new Product { ProductIt = 4, Name = "Swiss", CategoryId= 1 },
                new Product { ProductIt = 5, Name = "Cheshire", CategoryId= 1 },
                new Product { ProductIt = 6, Name = "Ricotta", CategoryId= 1 },
                new Product { ProductIt = 7, Name = "Chancol", CategoryId= 1 },
                new Product { ProductIt = 8, Name = "Culotte", CategoryId= 2 },
                new Product { ProductIt = 9, Name = "Lomo", CategoryId= 2 },
                new Product { ProductIt = 10, Name = "Puyaso", CategoryId= 2 },
                new Product { ProductIt = 11, Name = "RibEye", CategoryId= 2 },
                new Product { ProductIt = 12, Name = "T-bode", CategoryId= 2 },
                new Product { ProductIt = 13, Name = "Brisket", CategoryId= 2 },
                new Product { ProductIt = 14, Name = "Salmon", CategoryId= 3 },
                new Product { ProductIt = 15, Name = "Atun", CategoryId= 3 },
                new Product { ProductIt = 16, Name = "Sardina", CategoryId= 3 },
                new Product { ProductIt = 17, Name = "Frances", CategoryId= 4 },
                new Product { ProductIt = 18, Name = "Dulce", CategoryId= 4 },
                new Product { ProductIt = 19, Name = "Xecas", CategoryId= 4 },
                new Product { ProductIt = 20, Name = "Cubiletes", CategoryId= 4 },
                new Product { ProductIt = 21, Name = "Pirujo", CategoryId= 4 },
                new Product { ProductIt = 22, Name = "5 Carnes", CategoryId= 5 },
                new Product { ProductIt = 23, Name = "Hawaiana", CategoryId= 5 },
                new Product { ProductIt = 24, Name = "Margarita", CategoryId= 5 },
                new Product { ProductIt = 25, Name = "Americana", CategoryId= 5 }
                );
        }
    }
}
