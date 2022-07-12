using NUnit.Framework;
using Selenium.BasesClass;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Linq;

namespace Selenium
{
	[TestFixture]
	public class incializadorTest : BasesTest
	{
        [Test]
        public void Localizadores_Test()
        {
            this.driver.FindElement(By.ClassName("className"));
            this.driver.FindElement(By.CssSelector("css"));
            this.driver.FindElement(By.Id("id"));
            this.driver.FindElement(By.LinkText("text"));
            this.driver.FindElement(By.Name("name"));
            this.driver.FindElement(By.PartialLinkText("pText"));
            this.driver.FindElement(By.TagName("input"));
            this.driver.FindElement(By.XPath("//*[@id='editor']"));
        }


        [Test]
        public void Browser_Test_1()
        {
            // NuGet: Selenium.WebDriver.ChromeDriver

            IWebDriver driver = new ChromeDriver();
            // NuGet: Selenium.Mozilla.Firefox.Webdriver

            IWebDriver driverFireFox = new FirefoxDriver();
            // NuGet: Selenium.WebDriver.IEDriver

            IWebDriver driverIE = new InternetExplorerDriver();
            // NuGet: Selenium.WebDriver.EdgeDriver

            IWebDriver driverEdge = new EdgeDriver();
        }

        [Test]
        public void Browser_Test_2()
        {
            // Navigate to a page 
            this.driver.Navigate().GoToUrl(@"http://google.com");
            // Get the title of the page
            string title = this.driver.Title;
            Console.Write(title);
            // Get the current URL
            string url = this.driver.Url;
            Console.Write(url);
            // Get the current page HTML source
            string html = this.driver.PageSource;
            Console.Write(html);
        }




        [Test]
        public void operaciones_WebElement_Test_1()
        {
            IWebElement element = driver.FindElement(By.Id("dropdownMenuButton"));
            element.Click();
            element.SendKeys("someText");
            element.Clear();
            element.Submit();
            string innerText = element.Text;
            bool isEnabled = element.Enabled;
            bool isDisplayed = element.Displayed;
            bool isSelected = element.Selected;
            IWebElement elemento = driver.FindElement(By.Id("id"));
            SelectElement select = new SelectElement(elemento);
            select.SelectByIndex(1);
            select.SelectByText("Ford");
            select.SelectByValue("ford");
            select.DeselectAll();
            select.DeselectByIndex(1);
            select.DeselectByText("Ford");
            select.DeselectByValue("ford");
            IWebElement selectedOption = select.SelectedOption;
            IList<IWebElement> allSelected = select.AllSelectedOptions;
            bool isMultipleSelect = select.IsMultiple;
        }

        [Test]
        public void Caso_prueba_operaciones()
        {
            IWebElement link = driver.FindElement(By.PartialLinkText("Enabled and disa"));
            link.Click();
            IWebElement inputFieldText = driver.FindElement(By.Id("input"));

            inputFieldText.SendKeys("Texto nuevo");
            inputFieldText.Clear();
            inputFieldText.Submit();

            inputFieldText.SendKeys("Texto dos");
            string innerText = inputFieldText.Text;
            Console.Write(innerText);


            IWebElement disableInputFieldText = driver.FindElement(By.Id("disabledInput"));
            bool isEnabled = disableInputFieldText.Enabled;
            if (isEnabled)
            {
                inputFieldText.Clear();
                inputFieldText.SendKeys("input Habilitado");
            }
            else
            {
                inputFieldText.Clear();
                inputFieldText.SendKeys("input deshabilitado");
            }

        }

        [Test]
        public void operaciones_WebElement_Test_2()
        {
            IWebElement element = driver.FindElement(By.Id("search-strings"));
            element.Click();
            element.SendKeys("someText");
            element.Clear();
            element.Submit();
            string innerText = element.Text;
            bool isEnabled = element.Enabled;
            bool isDisplayed = element.Displayed;
            bool isSelected = element.Selected;
            IWebElement elemento = driver.FindElement(By.Id("id"));
            SelectElement select = new SelectElement(elemento);
            select.SelectByIndex(1);
            select.SelectByText("Ford");
            select.SelectByValue("ford");
            select.DeselectAll();
            select.DeselectByIndex(1);
            select.DeselectByText("Ford");
            select.DeselectByValue("ford");
            IWebElement selectedOption = select.SelectedOption;
            IList<IWebElement> allSelected = select.AllSelectedOptions;
            bool isMultipleSelect = select.IsMultiple;
        }


        [Test]
        public void TakeImage_Test()
        {
            IWebElement qbox = driver.FindElement(By.Name("q"));

            qbox.SendKeys("Selenium　C#");

            qbox.Submit();

            driver.Manage().Window.FullScreen();
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile("ImagenPrueba.png", ScreenshotImageFormat.Png);
            Console.ReadKey();
        }





        [Test]
        public void browser_advanced_Test()
        {
            // Handle JavaScript pop-ups
            IAlert a = driver.SwitchTo().Alert();
            a.Accept();
            a.Dismiss();

            // Switch between browser windows or tabs
            ReadOnlyCollection<string> windowHandles = driver.WindowHandles;
            string firstTab = windowHandles.First();
            string lastTab = windowHandles.Last();
            driver.SwitchTo().Window(lastTab);

            // Navigation history
            this.driver.Navigate().Back();
            this.driver.Navigate().Refresh();
            this.driver.Navigate().Forward();

            // Focus on a control
            IWebElement link = driver.FindElement(By.PartialLinkText("Previous post"));
            // Option 1.
            link.SendKeys(string.Empty);
            // Option 2.
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].focus();", link);
            // Maximize window
            this.driver.Manage().Window.Maximize();
            // Add a new cookie
            Cookie cookie = new OpenQA.Selenium.Cookie("key", "value");
            this.driver.Manage().Cookies.AddCookie(cookie);
            // Get all cookies
            var cookies = this.driver.Manage().Cookies.AllCookies;
            // Delete a cookie by name
            this.driver.Manage().Cookies.DeleteCookieNamed("CookieName");
            // Delete all cookies
            this.driver.Manage().Cookies.DeleteAllCookies();
            //Taking a full-screen screenshot
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile("ImageFormat.Png");
            // Wait until a page is fully loaded via JavaScript
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(30));
            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)this.driver).ExecuteScript("return document.readyState").Equals("complete");
            });
            // Switch to frames
            this.driver.SwitchTo().Frame(1);
            this.driver.SwitchTo().Frame("frameName");
            IWebElement element = this.driver.FindElement(By.Id("id"));
            this.driver.SwitchTo().Frame(element);
            // Switch to the default document
            this.driver.SwitchTo().DefaultContent();
        }


        
    }




}

