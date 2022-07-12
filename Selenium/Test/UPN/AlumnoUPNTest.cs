using System;
using NUnit.Framework;
using Selenium.BasesClass;
using Selenium.PagesObject;
using Selenium.PagesObject.UPN;
using Selenium.PagesObject.UPN.Intranet;
using Selenium.Utilitarios;

namespace Selenium.Test.UPN
{
	[TestFixture]
	public class AlumnoUPNTest : BasesTest
	{
		private UPNLoginPage _UPNLoginPage;
		private UPNMainPage _UPNMainPage;
		private UPNIntranetMainPage _UPNIntranetMainPage;
		private AlumnoPage _AlumnoPage;

		[SetUp]
		public void init()
		{
			_UPNLoginPage = new UPNLoginPage(driver);
			_UPNMainPage = new UPNMainPage(driver);
			_UPNIntranetMainPage = new UPNIntranetMainPage(driver);
			_AlumnoPage = new AlumnoPage(driver);
		}

		[Test(Description = "buscar alumno por codigo")]
		public void buscar_alumno_Test()
		{
			_UPNLoginPage.goToPage();
			_UPNLoginPage.Login(Constantes.user, Constantes.password);
			_UPNMainPage.click_Direccion_Img();

			//Espera como maximo 10 segundo a que se genera la nueva ventana
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
			//Cambio al nuevo TAB
			driver.SwitchTo().Window(driver.WindowHandles[1]); // represenat la posicion del tab
			_UPNIntranetMainPage.Item_Alumno_Click();

			_AlumnoPage.buscar_alumno_ID("n00159324");

			string id = _AlumnoPage.alum_Id.Text;
			string nombre = _AlumnoPage.alum_nombre.Text;
			string email = _AlumnoPage.alum_email.Text;
			string estado = _AlumnoPage.alum_estado.Text;


			//Validar assert
			Assert.AreEqual(id, "N00159324");
			Assert.AreEqual(nombre, "VERDEGUER VALDERRAMA, DIEGO CESAR");
			Assert.AreEqual(email, "N00159324@upn.pe");
			Assert.AreEqual(estado, "ACTIVO");

			if(estado == "INACTIVO")
            {
				_AlumnoPage.alum_Id.Click();
            }

		}
	}
}

