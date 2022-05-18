using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebShopApp.Data;
using WebShopApp.Interfaces;
using WebShopApp.Tests.Fixtures;
using Xunit;

namespace WebShopApp.Tests.Services
{
    public class CategoryService_Should
    {
        [Fact]
        public async Task CategoryService_Get_Should_Return_Multiple_Categories()
        {
            // Arrange
            var sut = new Mock<ApplicationDbContext>();
            sut.Setup(x => x.Categories.AsNoTracking().ToArrayAsync(CancellationToken.None))
                .Returns(CategoryFixtures.GetTestCategoriesEntity().ToArray());
      


            // Act
            var result = await 

            // Assert
        }




        [Fact]
        public async Task ProductService_Should_Return_Type_Products()
        {
            // Arrange
            var sut = new Mock<IProductService>();

            // Act
            var result = await sut.Object.GetProducts();

            // Assert
            result.Should().BeOfType<ProductModel[]>();
        }
    }
}
