using System;
using NUnit.Framework;
using Selenium.BasesClass;
using Selenium.PagesObject;

namespace Selenium.Test.UPN
{
	public class UPNMainTest: BasesTest
	{
		[SetUp]
		public void init()
        {
			_UPNMainPage = new UPNMainPage(driver);
		}
		private UPNMainPage _UPNMainPage;
		[Test(Description = "Caso Link Autocomplete")]
		public void Test_autocomplete_Click()
		{
			_UPNMainPage.goToPage();
			_UPNMainPage.click_Direccion_Img();
		}
	}
}

