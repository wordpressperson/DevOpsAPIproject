using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController controller=new WeatherForecastController();
        [Fact]
        public void checkReturnName()
        {
            var returnValue=controller.Get();
            Assert.Equal("It is working", returnValue);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
