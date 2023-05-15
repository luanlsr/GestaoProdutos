using GestaoProdutos.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Infra.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.Quantity)
                .IsRequired();

            builder.HasOne(p => p.Stock)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.StockId);

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
