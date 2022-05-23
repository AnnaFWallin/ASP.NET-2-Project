using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShopApp.Models;
using WebShopApp.Repository;
using WebShopApp.Tests.Fixtures;
using WebShopApp.Tests.Repository;
using WebShopApp.Tests;
using Xunit;

namespace WebShopApp.Tests.ProductRespositoryManagement
{
    public class IProductRepository_Should
    {
        [Fact]
        public async Task GetAsync_Should_Return_ListOfProductModel()
        {
            // Arrange
            var sut = new Mock<IProductRepository>();
            sut.Setup(s => s.GetAsync()).Returns(ProductModelFixtures.GetAsync());

            // Act
            var result = await sut.Object.GetAsync();

            // Assert
            result.Should().BeOfType<List<ProductModel>>();
        }

        
    }
}
