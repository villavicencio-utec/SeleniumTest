using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using SeleniumExtras.PageObjects;



namespace Selenium.POM
{
	public class GoogleHomePage 
    {
        String test_url = "https://www.google.com";

        public IWebDriver driver;
        private WebDriverWait wait;



        public GoogleHomePage(IWebDriver _driver)
        {
            this.driver = _driver;                        
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl(test_url);
        }


        //Segunda forma de localizar elementos en POM

        [FindsBy(How = How.LinkText, Using = "comboId")]
        [CacheLookup] // almacenar el elemento.
        private IWebElement elem_search_text;

        [FindsBy(How = How.LinkText, Using = "Acceder")]
        [CacheLookup]
        private IWebElement acceso_btn;

        public void buscarElemento(string input_search)
        {
            elem_search_text.SendKeys(input_search);
        }

        public void Acceder()
        {
            acceso_btn.Click();
        }
    }
}

