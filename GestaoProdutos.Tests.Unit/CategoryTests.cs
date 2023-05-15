using GestaoProdutos.Domain.Core.Entities;
using GestaoProdutos.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProdutos.Tests.Unit
{
    public class CategoryTests
    {
        [Fact]
        public void Category_ShouldImplementIEntity()
        {
            // Arrange
            var category = new Category();

            // Act
            var implementsIEntity = category is IEntity;

            // Assert
            Assert.True(implementsIEntity);
        }

        [Fact]
        public void Category_ShouldHaveProperties()
        {
            // Arrange
            var category = new Category();

            // Act
            category.Description = "Test Category";

            // Assert
            Assert.Equal("Test Category", category.Description);
        }
    }
}
