using GestaoProdutos.Domain.Core.Entities;
using GestaoProdutos.Infra.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        DbSet<Product>? Products { get; set; }
        DbSet<Stock>? Stocks { get; set; }
        DbSet<Category>? Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("WebApiDatabase"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new StockConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
