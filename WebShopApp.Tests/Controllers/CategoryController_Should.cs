using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using WebShopApp.Controllers;
using WebShopApp.Interfaces;
using WebShopApp.Services;
using WebShopApp.Tests.Fixtures;
using Xunit;

namespace WebShopApp.Tests
{
    public class CategoryController_Should
    {

        [Fact]
        public async Task CategoryController_Should_Return_ViewCategoryResult()
        {
            // Arrange 
            var categoryServiceMock = new Mock<ICategoryService>();
            categoryServiceMock.Setup(x => x.GetAsync(CancellationToken.None))
                .ReturnsAsync(CategoryFixtures.GetTestCategoriesEntity());

            var sut = new CategoryController(categoryServiceMock.Object);

            // Act
            var result = await sut.Index(CancellationToken.None);

            // Assert
            result.Should().BeOfType<ViewResult>();
        }

    }
}
