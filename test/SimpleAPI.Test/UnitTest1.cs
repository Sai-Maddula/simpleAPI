using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsStuff()
        { 
            var returnValue = controller.Get();
            Assert.Equal("Hello Welcome to CTC!", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}