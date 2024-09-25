using System.Collections.Generic;
using Xunit;
using csharpAPI.Models;
using csharpAPI.Services;

namespace csharpAPI.Tests
{
    public class PublicHolidayServiceTests
    {
        private readonly IPublicHolidayService _service;

        public PublicHolidayServiceTests()
        {
            _service = new PublicHolidayService();
        }

        [Fact]
        public void GetPublicHolidays_ReturnsListOfPublicHolidays_ForValidCountryAndYear()
        {
            // Arrange
            var country = "UnitedStates";
            var year = 2023;

            // Act
            var result = _service.GetPublicHolidays(country, year);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<PublicHoliday>>(result);
            Assert.Equal(2, ((List<PublicHoliday>)result).Count);
        }

        [Fact]
        public void GetPublicHolidays_ReturnsEmptyList_ForInvalidCountry()
        {
            // Arrange
            var country = "InvalidCountry";
            var year = 2023;

            // Act
            var result = _service.GetPublicHolidays(country, year);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<PublicHoliday>>(result);
            Assert.Empty((List<PublicHoliday>)result);
        }

        [Fact]
        public void GetPublicHolidays_ReturnsEmptyList_ForInvalidYear()
        {
            // Arrange
            var country = "UnitedStates";
            var year = 9999;

            // Act
            var result = _service.GetPublicHolidays(country, year);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<PublicHoliday>>(result);
            Assert.Empty((List<PublicHoliday>)result);
        }
    }
}
