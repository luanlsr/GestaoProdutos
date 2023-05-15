using GestaoProdutos.Domain.Core.Entities;
using GestaoProdutos.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Tests.Unit
{
    public class StockTests
    {
        [Fact]
        public void Stock_ShouldImplementIEntity()
        {
            // Arrange
            var stock = new Stock();

            // Act
            var implementsIEntity = stock is IEntity;

            // Assert
            Assert.True(implementsIEntity);
        }

        [Fact]
        public void Stock_ShouldHaveProperties()
        {
            // Arrange
            var stock = new Stock();

            // Act
            stock.Name = "Test Stock";
            stock.CreatedAt = DateTime.Now;

            // Assert
            Assert.Equal("Test Stock", stock.Name);
            Assert.NotNull(stock.CreatedAt);
        }
    }
}
