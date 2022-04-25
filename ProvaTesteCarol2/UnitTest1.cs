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
        private IWebDriver driver;
        private string baseURL;
        private bool acceptNextAlert = true;


        [Fact]
        public void Test1()
        {
            ////act
            //driver.Navigate().GoToUrl("https://www.alura.com.br/");

            ////assert
            //Assert.Contains("Caelum", driver.Title);


            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            baseURL = "https://www.google.com/";

            TheVortxTest();
        }


        public void TheVortxTest()
        {
            driver.Navigate().GoToUrl(baseURL + "chrome://newtab/");
            
            driver.Navigate().GoToUrl("https://vortx.com.br/");

            driver.FindElement(By.XPath("//div[@id='disclaimer']/div/button")).Click();

            driver.FindElement(By.Id("investidor")).Click();

            //foreach (var item in x)
            //{
            //    var vvvv = ((OpenQA.Selenium.WebElement)item).Text;


            //    //var x2 = driver.FindElements(By.Id());
            //    //foreach (var item2 in x2)
            //    //{
            //    //    item2.Click();
            //    //}

            //    // item.Click();
            //}

            //driver.FindElement(By.Id("investidor")).Click();
            //driver.Navigate().GoToUrl("https://vortx.com.br/investidor/cra");


            //driver.FindElement(By.XPath("//div[@id='investidor4']/div")).Click();
            //driver.FindElement(By.XPath("//div[@id='__next']/div/section/div[2]/div/div[2]/div/div/div/table/tbody/tr/td/a/div")).Click();
            //driver.FindElement(By.Id("2")).Click();
            //driver.FindElement(By.XPath("//div[@id='Assembleias']/p")).Click();
            //driver.FindElement(By.XPath("//div[@id='doc-Assembleias']/a[2]/p")).Click();
            //// ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
            //driver.Close();
            //// ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_local | ]]
            //driver.FindElement(By.XPath("//div[@id='__next']/div/section")).Click();
            //driver.FindElement(By.XPath("//div[@id='__next']/div/section/section/section/div/button/span")).Click();
            //driver.FindElement(By.XPath("//input[@value='']")).Click();
            //driver.FindElement(By.XPath("//div[@id='modal-cota']/div/div[2]/div/div/div[2]/div[2]/div/div/div[2]/div[2]/div[2]/div[5]")).Click();
            //driver.FindElement(By.XPath("//input[@value='']")).Click();
            //driver.FindElement(By.XPath("//div[@id='modal-cota']/div/div[2]/div/div[2]/div[2]/div[2]/div/div/div[2]/div[2]/div[2]/div[6]")).Click();
            //driver.FindElement(By.XPath("//div[@id='modal-cota']/div/div[2]/button/span")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Atualizar'])[1]/following::*[name()='svg'][3]")).Click();
            //driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Export as CSV'])[1]/following::li[1]")).Click();
            //driver.FindElement(By.XPath("//div[@id='modal-cota']/div/div/p")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }


    }




}
