using GestaoProdutos.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Infra.Data.Configuration
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.ToTable("Stocks");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
