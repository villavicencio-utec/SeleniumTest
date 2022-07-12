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
	public class AlumnoTest : BasesTest
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

		[Test(Description = "Buscar alumno n00159324", Author ="jvillavicencio"), Order(1), Category("Alumnos")]			
		[TestCase("n00159324")]
		public void buscar_alumno_Test(string alumno)
		{
			_UPNLoginPage.goToPage();
			_UPNLoginPage.Login(Constantes.user, Constantes.password);
			_UPNMainPage.click_Direccion_Img();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
			driver.SwitchTo().Window(driver.WindowHandles[1]);
			_UPNIntranetMainPage.Item_Alumno_Click();
			_AlumnoPage.buscar_alumno_ID(alumno);
		}



		[Test(Description = "Validar datos del alumno en tabla", Author = "jvillavicencio"), Order(2), Category("Alumnos")]
		public void validar_datos_alumno_Test()
		{
			string id = _AlumnoPage.alum_Id.Text;
			string nombre = _AlumnoPage.alum_nombre.Text;
			string email = _AlumnoPage.alum_email.Text;
			string estado = _AlumnoPage.alum_estado.Text;
			Assert.AreEqual(id, "N00159324");
			Assert.AreEqual(nombre, "VERDEGUER VALDERRAMA, DIEGO CESAR");
			Assert.AreEqual(email, "N00159324@upn.pe");
			Assert.AreEqual(estado, "ACTIVO");
		}


		[Test(Description = "Usuario activo", Author = "jvillavicencio"), Order(3), Category("Alumnos")]
		public void alumno_activo_Test()
		{
			string estado = _AlumnoPage.alum_estado.Text;
			if (estado == "ACTIVO")
            {
                _AlumnoPage.alum_Id.Click();
				// Continuar con flujo
                
            }
        }
		[Test(Description = "Usuario inactivo", Author = "jvillavicencio"), Order(4), Category("Alumnos"), Ignore("Acuerdo en comite de QA")]
		public void alumno_inactivo_Test()
		{
			string estado = _AlumnoPage.alum_estado.Text;
			if (estado == "INACTIVO")
			{
				_AlumnoPage.alum_Id.Click();
				// No deberia clickear o mistrar datos.
				
			}
		}
	}

}

