using Selenium.POM;
using NUnit.Framework;

using Selenium.BasesClass;
using OpenQA.Selenium;

namespace Selenium.Test
{
	public class GoogleHomePageTest : BasesTest
	{
        private GoogleHomePage _GoogleHomePage;

        [Test(Description = "Verificar busqueda")]
        public void TestBusqueda()
        {
            _GoogleHomePage = new GoogleHomePage(driver);
            _GoogleHomePage.buscarElemento("Selenim C#");

        }

        [Test(Description = "Acceso")]
        public void Test_acceso()
        {
            _GoogleHomePage = new GoogleHomePage(driver);
            _GoogleHomePage.Acceder();
        }

        [Test]
        public void TestBusqueda_Selenium()
        {
            driver.Navigate().GoToUrl("wwww.google.com.pe");
            IWebElement searchText = driver.FindElement(By.Name("q"));
            searchText.SendKeys("Selenium C#");
        }


        //Implementado sin POM   - 4 modificaciones
        [Test]
        public void TestBusqueda_1()
        {
            driver.Navigate().GoToUrl("wwww.google.com.pe");
            IWebElement searchText = driver.FindElement(By.Name("comboId"));
            searchText.SendKeys("1");
        }

        [Test]
        public void TestBusqueda_2()
        {
            driver.Navigate().GoToUrl("wwww.google.com.pe");
            IWebElement searchText = driver.FindElement(By.Name("comboId"));
            searchText.SendKeys("2");
        }


        [Test]
        public void TestBusqueda_3()
        {
            driver.Navigate().GoToUrl("wwww.google.com.pe");
            IWebElement searchText = driver.FindElement(By.Name("comboId"));
            searchText.SendKeys("3");
        }
        [Test]
        public void TestBusqueda_4()
        {
            driver.Navigate().GoToUrl("wwww.google.com.pe");
            IWebElement searchText = driver.FindElement(By.Name("comboId"));
            searchText.SendKeys("4");
        }


        // Implementacion con POM - 1 modificacion
        [Test(Description = "Verificar busqueda")]
        public void POM_1()
        {
            _GoogleHomePage = new GoogleHomePage(driver);
            _GoogleHomePage.buscarElemento("1");

        }
        [Test(Description = "Verificar busqueda")]
        public void POM_2()
        {
            _GoogleHomePage = new GoogleHomePage(driver);
            _GoogleHomePage.buscarElemento("2");


        }
        [Test(Description = "Verificar busqueda")]
        public void POM_3()
        {
            _GoogleHomePage = new GoogleHomePage(driver);
            _GoogleHomePage.buscarElemento("3");



        }

        [Test(Description = "Verificar busqueda")]
        public void POM_4()
        {
            _GoogleHomePage = new GoogleHomePage(driver);
            _GoogleHomePage.buscarElemento("4");

            // porque POM es mantenible.

        }
    }
}

