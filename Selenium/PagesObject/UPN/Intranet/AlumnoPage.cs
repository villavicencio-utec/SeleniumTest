using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace Selenium.PagesObject.UPN.Intranet
{
	public class AlumnoPage
	{
        string _url = "https://intranet.upn.edu.pe/direccion/secure/ACTUALIZARDATOSALUMNO.ASPX";
        public IWebDriver driver;
        private WebDriverWait wait;

        public AlumnoPage(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(_driver, this);
        }

        public void goToPage()
        {
            driver.Navigate().GoToUrl(_url);
        }

        // Paso 1.  Localizar los webelementes de la pagina
        [FindsBy(How = How.Id, Using = "ContentPlaceHolder1_txtBuscar")]
        [CacheLookup]
        public IWebElement id_alumno_txt;

        [FindsBy(How = How.Id, Using = "ContentPlaceHolder1_btnBuscar")]
        [CacheLookup]
        public IWebElement buscar_btn;


        [FindsBy(How = How.XPath, Using = "/html/body/form/div[3]/div/div[2]/div/div/div/div/div[2]/div/div/div[3]/table/tbody/tr[2]/td[1]/a")]
        [CacheLookup]
        public IWebElement alum_Id;


        [FindsBy(How = How.XPath, Using = "/html/body/form/div[3]/div/div[2]/div/div/div/div/div[2]/div/div/div[3]/table/tbody/tr[2]/td[2]")]
        [CacheLookup]
        public IWebElement alum_nombre;

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[3]/div/div[2]/div/div/div/div/div[2]/div/div/div[3]/table/tbody/tr[2]/td[3]")]
        [CacheLookup]
        public IWebElement alum_email;

        [FindsBy(How = How.XPath, Using = "/html/body/form/div[3]/div/div[2]/div/div/div/div/div[2]/div/div/div[3]/table/tbody/tr[2]/td[4]")]
        [CacheLookup]
        public IWebElement alum_estado;


        //2. Acciones basicas posibles que se puedan aplicar a los webelements
        public void id_alumno_txt_Texto(string prId)
        {
            id_alumno_txt.SendKeys(prId);
        }

        public void buscar_btn_click()
        {
            buscar_btn.Click();
        }


        public void buscar_alumno_ID(string prId)
        {
            id_alumno_txt_Texto(prId);
            buscar_btn_click();
        }






    }
}

