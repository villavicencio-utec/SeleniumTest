using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Selenium.PagesObject.UPN
{
	public class UPNLoginPage
	{
        String _url = "https://intranet.upn.edu.pe/WebLogin/Bienvenido.aspx";

        public IWebDriver driver;
        private WebDriverWait wait;


        // Paso 0. Constructor para inicializar el driver por pagina
        public UPNLoginPage(IWebDriver _driver) 
        {
            this.driver = _driver;
            PageFactory.InitElements(_driver, this);  
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl(_url);
        }


        // Paso 1.  Localizar los webelementes de la pagina

        [FindsBy(How = How.Id, Using = "logUPN_UserName")]
        [CacheLookup]
        public IWebElement username_text;

        [FindsBy(How = How.Id, Using = "logUPN_Password")]
        [CacheLookup]
        public IWebElement psssword_text;

        [FindsBy(How = How.Id, Using = "logUPN_LoginButton")]
        [CacheLookup] 
        public IWebElement login_btn;

        [FindsBy(How = How.PartialLinkText, Using = "Cambia tu")]
        [CacheLookup]
        public IWebElement change_password_link;


        //2. Acciones basicas posibles que se puedan aplicar a los webelements
        public void username_text_Tx(string username)
        {
            username_text.SendKeys(username);
        }

        public void psssword_text_Tx(string password)
        {
            psssword_text.SendKeys(password);
        }

        public void login_btnClick()
        {
            login_btn.Click();
        }

        public void change_password_linkClick()
        {
            change_password_link.Click();
        }



        //3. Creacion de flujos basicos de la pagina.
        public void Login(string username, string password)
        {
            username_text_Tx(username);
            psssword_text_Tx(password);
            login_btnClick();
        }


    }
}

