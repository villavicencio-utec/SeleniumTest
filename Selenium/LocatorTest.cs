using NUnit.Framework;
using Selenium.BasesClass;
using OpenQA.Selenium;
using System.Threading;

namespace Selenium
{
    [TestFixture]
    public class Tests : BasesTest
    {

        [Test,Order(1)]
        public void Test_Id()
        {
            IWebElement elementId = driver.FindElement(By.Id("email"));
            elementId.SendKeys("Producto a buscar");
            Thread.Sleep(2000);
        }

        [Test, Order(2)]
        public void Test_Name()
        {
            IWebElement elementId = driver.FindElement(By.Name("pass"));
            elementId.Click();
            Thread.Sleep(2000);
        }


        [Test, Order(3)]
        public void Test_Class()
        {
            IWebElement elementId = driver.FindElement(By.ClassName("_42ft _4jy0 _6lth _4jy6 _4jy1 selected _51sy"));
            elementId.Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
        }

        //[Test, Order(4)]
        //public void Test_cssSelector()
        //{
        //    IWebElement elementId = driver.FindElement(By.CssSelector("#email"));
        //    elementId.SendKeys("Adicional");
        //    Thread.Sleep(2000);
        //}

        [Test, Order(4)]
        public void Test_PartialLink()
        {
            IWebElement elementId = driver.FindElement(By.PartialLinkText("¿Olvidaste"));
            elementId.Click();
            Thread.Sleep(2000);
        }

        [Test, Order(5)]
        public void Test_Link()
        {
            IWebElement elementId = driver.FindElement(By.PartialLinkText("¿Olvidaste tu contraseña?"));
            elementId.Click();
            Thread.Sleep(2000);
        }

        [Test, Order(6)]
        public void Test_Xpath()
        {
            IWebElement elementId = driver.FindElement(By.XPath(".//*[@id='email']"));
            elementId.SendKeys("Correo con XPath");
            Thread.Sleep(2000);
        }
    }
}
