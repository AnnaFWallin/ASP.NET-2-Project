﻿using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using WebShopApp.Controllers;
using WebShopApp.Services;
using WebShopApp.Tests.Fixtures;
using Xunit;

namespace WebShopApp.Tests
{
    public class ShopPageController_Should
    {

        [Fact]
        public async Task ShopPageController_Should_Return_ViewResult()
        {
            // Arrange 
            var mockProductService = new Mock<IProductService>();
            mockProductService.Setup(x => x.GetProducts())
                .ReturnsAsync(ProductFixtures.GetTestProducts());

            var sut = new ShopPageController(mockProductService.Object);

            // Act
            var result = await sut.Index();

            // Assert
            result.Should().BeOfType<ViewResult>();
        }

    }
}
