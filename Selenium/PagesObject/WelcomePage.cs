using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Selenium.PagesObject
{
	public class WelcomePage
	{
        String test_url = "https://formy-project.herokuapp.com";

        public String getUrl() { return test_url; }
        public IWebDriver driver;
        private WebDriverWait wait;


        public IWebElement autocomplete_link;
        public IWebElement buttons_link;
        public IWebElement chbox_link;
        public IWebElement drag_link;
        public IWebElement drop_link;
        public IWebElement enabled_link;
        //...

        public WelcomePage(IWebDriver _driver)
        {
            
            this.driver = _driver;

            //1. Localizar los elementos de la pagina
            this.autocomplete_link = driver.FindElement(By.LinkText("Autocomplete"));
            this.buttons_link = driver.FindElement(By.LinkText("Buttons"));
            this.chbox_link = driver.FindElement(By.LinkText("Checkbox"));
            this.drag_link = driver.FindElement(By.PartialLinkText("Drag "));
            this.drop_link = driver.FindElement(By.LinkText("Dropdown"));
            this.enabled_link = driver.FindElement(By.PartialLinkText("Enabled and"));
        }




        //[FindsBy(How = How.PartialLinkText, = "Autocomplete")]
        //[CacheLookup] // almacenar el elemento.
        //private IWebElement autocomplete_link;


        //[FindsBy(How = How.PartialLinkText, Using = "Buttons")]
        //[CacheLookup] // almacenar el elemento.
        //private IWebElement buttons_link;

        //[FindsBy(How = How.LinkText, Using = "Checkbox")]
        //[CacheLookup] // almacenar el elemento.
        //private IWebElement chbox_link;
        //2. Indicando las posibles acciones de la pagina
        public void click_autocomplete_link()
        {
            autocomplete_link.Click();
        }

        public void click_buttons_link()
        {
            buttons_link.Click();
        }

        public void click_chbox_link()
        {
            chbox_link.Click();
        }

        public void click_drag_link()
        {
            drag_link.Click();
        }

        public void click_drop_link()
        {
            drop_link.Click();
        }

        public void click_enabled_link()
        {
            enabled_link.Click();
        }

        //public void goToPage()
        //{
        //    driver.Url = test_url;
        //    //driver.Navigate().GoToUrl();
        //}

    }
}

