using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Selenium.PagesObject
{
	public class UPNMainPage
	{
        String _url = "https://intranet.upn.edu.pe/WebLogin/Bienvenido.aspx";

        public IWebDriver driver;
        private WebDriverWait wait;

        public UPNMainPage(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(_driver, this);
        }


        // Paso 1.  Localizar los webelementes de la pagina

        [FindsBy(How = How.XPath, Using = "//img[@alt='Dirección']")]        
        [CacheLookup]
        public IWebElement direccion_Img;


        //2. Acciones basicas posibles que se puedan aplicar a los webelements
        public void click_Direccion_Img()
        {
            direccion_Img.Click();
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl(_url);
        }
    }
}

