using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using Selenium.Utilitarios;

namespace Selenium.BasesClass
{

	public class BasesTest
	{
		public IWebDriver driver;

		[SetUp]
		public void Open()
        {
			driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

		[TearDown]
		public void Close()
        {
			//driver.Quit();
        }

	}
}

