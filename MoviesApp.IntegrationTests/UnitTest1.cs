using NUnit.Framework;

namespace MoviesApp.IntegrationTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestAssignment()
        {
            var weatherForecast = new WeatherForecast
            {
                TemperatureC = 14
            };

            Assert.AreEqual(14, weatherForecast.TemperatureC);
        }
    }
}