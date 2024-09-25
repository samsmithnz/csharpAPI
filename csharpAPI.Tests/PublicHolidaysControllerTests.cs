using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using csharpAPI.Controllers;
using csharpAPI.Models;
using csharpAPI.Services;

namespace csharpAPI.Tests
{
    public class PublicHolidaysControllerTests
    {
        private readonly Mock<IPublicHolidayService> _mockService;
        private readonly PublicHolidaysController _controller;

        public PublicHolidaysControllerTests()
        {
            _mockService = new Mock<IPublicHolidayService>();
            _controller = new PublicHolidaysController(_mockService.Object);
        }

        [Fact]
        public void GetPublicHolidays_ReturnsOkResult_WithListOfPublicHolidays()
        {
            // Arrange
            var country = "UnitedStates";
            var year = 2023;
            var publicHolidays = new List<PublicHoliday>
            {
                new PublicHoliday { Name = "New Year's Day", Date = "2023-01-01" },
                new PublicHoliday { Name = "Independence Day", Date = "2023-07-04" }
            };
            _mockService.Setup(service => service.GetPublicHolidays(country, year)).Returns(publicHolidays);

            // Act
            var result = _controller.GetPublicHolidays(country, year);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<PublicHoliday>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
        }

        [Fact]
        public void GetPublicHolidays_ReturnsNotFoundResult_WhenCountryIsInvalid()
        {
            // Arrange
            var country = "InvalidCountry";
            var year = 2023;
            _mockService.Setup(service => service.GetPublicHolidays(country, year)).Returns((IEnumerable<PublicHoliday>)null);

            // Act
            var result = _controller.GetPublicHolidays(country, year);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public void GetPublicHolidays_ReturnsNotFoundResult_WhenYearIsInvalid()
        {
            // Arrange
            var country = "UnitedStates";
            var year = 9999;
            _mockService.Setup(service => service.GetPublicHolidays(country, year)).Returns((IEnumerable<PublicHoliday>)null);

            // Act
            var result = _controller.GetPublicHolidays(country, year);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }
    }
}
