using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace ProvaTesteCarol2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //act
            driver.Navigate().GoToUrl("https://www.alura.com.br/");


            //assert
            Assert.Contains("Caelum", driver.Title);
        }
    }
}
