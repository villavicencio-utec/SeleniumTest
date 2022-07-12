using System;
using NUnit.Framework;
using Selenium.BasesClass;
using Selenium.PagesObject.UPN;
using Selenium.Utilitarios;

namespace Selenium.Test
{
	[TestFixture]
	public class UPNLoginTest : BasesTest
	{

		private UPNLoginPage _UPNLoginPage;

		[SetUp]
		public void init()
		{
			_UPNLoginPage = new UPNLoginPage(driver);
		}

		[Test(Description = "Happy Path usuario y password correctos")]
		public void Login_Valid_User_Test()
		{
			_UPNLoginPage.goToPage();
			_UPNLoginPage.Login(Constantes.user, Constantes.password);
		}

		[Test(Description = "Happy Path usuario y password correctos")]
		public void Login_Invalid_User_Test()
		{

			_UPNLoginPage.goToPage();
			_UPNLoginPage.Login(Constantes.user+"Error", Constantes.password);
		}

		[Test(Description = "Happy Path usuario y password correctos")]
		public void Login_user_empty_Test()
		{

			_UPNLoginPage.goToPage();
			_UPNLoginPage.Login("", Constantes.password);
		}

		[Test(Description = "Happy Path usuario y password correctos")]
		public void Login_password_empty_Test()
		{
			_UPNLoginPage.goToPage();
			_UPNLoginPage.Login(Constantes.user,"");
		}

		[Test(Description = "Happy Path usuario y password correctos")]
		public void Login_empty_Test()
		{
			_UPNLoginPage.goToPage();
			_UPNLoginPage.Login("", "");
		}



	}
}

