using FluentAssertions;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebShopApp.Interfaces;
using WebShopApp.Models;
using WebShopApp.Tests.Fixtures;
using Xunit;

namespace WebShopApp.Tests.Services
{
    public class ProductsService_Should
    {
        [Fact]
        public async Task ProductService_Should_Return_Type_Products() //Olivias test
        {
            // Arrange
            var sut = new Mock<IProductService>();

            // Act
            var result = await sut.Object.GetProducts();

            // Assert
            result.Should().BeOfType<ProductModel[]>();
        }

        [Fact]
        public async Task GetAllProducts_Returns_ListOfProducts() //Olivias test
        {
            // Arrange
            var sut = new Mock<IProductService>();
            sut.Setup(s => s.GetProducts())
                .ReturnsAsync(ProductFixtures.GetTestProducts());

            // Act
            var result = await sut.Object.GetProducts();

            // Assert
            result.Should().BeOfType<List<ProductModel>>();
        }
    }
}
