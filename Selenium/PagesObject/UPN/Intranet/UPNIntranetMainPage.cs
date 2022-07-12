using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Selenium.PagesObject.UPN
{
	public class UPNIntranetMainPage
	{
		string _url = "https://intranet.upn.edu.pe/direccion/secure/Default.aspx";
        public IWebDriver driver;
        private WebDriverWait wait;

        public UPNIntranetMainPage(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(_driver, this);
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl(_url);
        }


        // Paso 1.  Localizar los webelementes de la pagina

        [FindsBy(How = How.LinkText, Using = "Contacto UPN ")]
        [CacheLookup]
        public IWebElement contacto_btn;



        [FindsBy(How = How.PartialLinkText, Using = "Datos ")]
        [CacheLookup]
        public IWebElement datos_personales_btn;


        // podria optimizar utilizar for para obtener los id = item3_(i)
        [FindsBy(How = How.Id, Using = "item3_5")]
        [CacheLookup]
        public IWebElement datos_personales_item_Alumnos;

        [FindsBy(How = How.Id, Using = "item3_6")]
        [CacheLookup]
        public IWebElement datos_personales_item_Generar;

        [FindsBy(How = How.Id, Using = "item3_7")]
        [CacheLookup]
        public IWebElement datos_personales_item_Docente;



        [FindsBy(How = How.LinkText, Using = "Informes ")]
        [CacheLookup]
        public IWebElement informes_btn;

        [FindsBy(How = How.LinkText, Using = "Matricula en Línea ")]
        [CacheLookup]
        public IWebElement matricula_btn;





        //2. Acciones basicas posibles que se puedan aplicar a los webelements
        public void contacto_btn_click()
        {
            contacto_btn.Click();
        }
        public void datos_personales_btn_click()
        {
            datos_personales_btn.Click();
        }
        public void informes_btn_click()
        {
            informes_btn.Click();
        }
        public void matricula_btn_click()
        {
            matricula_btn.Click();
        }
        public void datos_personales_item_Alumnos_click()
        {
            datos_personales_item_Alumnos.Click();
        }

        // Flujos basicos
        public void Item_Alumno_Click()
        {
            datos_personales_btn_click();
            datos_personales_item_Alumnos_click();
        }

    }
}

