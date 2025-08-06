using ForecastApp;
using ForecastApp.Controllers;

namespace ForecastTest.Controllers
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void Get_ReturnsFiveForecasts()
        {
            // Arrange
            var controller = new WeatherForecastController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(5, result.Count());
            foreach (var forecast in result)
            {
                Assert.IsType<WeatherForecast>(forecast);
                Assert.NotNull(forecast.Summary);
            }
        }
    }
}
