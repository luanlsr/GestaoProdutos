using GestaoProdutos.Domain.Core.Entities;
using GestaoProdutos.Domain.Core;

namespace GestaoProdutos.Tests.Unit
{
    public class ProductTests
    {
        [Fact]
        public void Product_ShouldImplementIEntity()
        {
            // Arrange
            var product = new Product();

            // Act
            var implementsIEntity = product is IEntity;

            // Assert
            Assert.True(implementsIEntity);
        }

        [Fact]
        public void Product_ShouldHaveProperties()
        {
            // Arrange
            var product = new Product();

            // Act
            product.Name = "Test Product";
            product.Description = "Test Description";
            product.Price = 10.99m;
            product.Quantity = 100;

            // Assert
            Assert.Equal("Test Product", product.Name);
            Assert.Equal("Test Description", product.Description);
            Assert.Equal(10.99m, product.Price);
            Assert.Equal(100, product.Quantity);
        }
    }
}