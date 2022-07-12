using NUnit.Framework;
using Selenium.BasesClass;
using OpenQA.Selenium;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;

namespace Selenium
{
    [TestFixture]
    public class Semana03B : BasesTest
    {

        
        [Test]
        public void dropDown_Test_1()
        {
            IWebElement link = driver.FindElement(By.PartialLinkText("Button"));
            link.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            IWebElement dropDownBtn = driver.FindElement(By.Id("btnGroupDrop1"));
            dropDownBtn.Click();

            //Thread.Sleep(3000);

            IWebElement item = driver.FindElement(By.LinkText("Dropdown link 2"));
            item.Click();

        }

        [Test]
        public void dropDown_Test_2()
        {
            IWebElement link = driver.FindElement(By.LinkText("Dropdown"));
            link.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            IWebElement dropDownBtn = driver.FindElement(By.Id("dropdownMenuButton"));
            dropDownBtn.Click();

            Thread.Sleep(2000);
            IWebElement linkFormulario = driver.FindElement(By.PartialLinkText("Complete Web Form"));
            linkFormulario.Click();

        }

        [Test]
        public void dropDown_Test_3()
        {
            IWebElement link = driver.FindElement(By.PartialLinkText("Complete W"));
            link.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            IWebElement dropDownBtn = driver.FindElement(By.XPath("select-menu"));

            SelectElement select = new SelectElement(dropDownBtn);

            select.SelectByIndex(1);
            Thread.Sleep(1000);
            select.SelectByText("10+");
        }

        [Test]
        public void datePicker_Test()
        {
            IWebElement link = driver.FindElement(By.LinkText("Datepicker"));
            link.Click();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            IWebElement datePickerField = driver.FindElement(By.Id("datepicker"));
            datePickerField.SendKeys("06/30/2022");
            datePickerField.SendKeys(DateTime.Now.ToString());
        }


        [Test]
        public void scroolDown_1()
        {
            IWebElement link = driver.FindElement(By.PartialLinkText("Page S"));
            link.Click();

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            // Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement field = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("name")));

            Actions actions = new Actions(driver);

            actions.MoveToElement(field);

            actions.Perform(); //Ejecuta la acción previamente configurada.
            field.SendKeys("Send Keys");
        }

        [Test]
        public void modal_test()
        {
            IWebElement link = driver.FindElement(By.LinkText("Modal"));
            link.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement btn = driver.FindElement(By.Id("modal - button"));
            btn.Click();

            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(driver => IsAlertShown(driver));
                IWebElement a = driver.FindElement(By.Id("ok-button"));
                a.Click();
                
            }
            catch (Exception e)
            {
                //exception handling
            }

  
        }
        bool IsAlertShown(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert();
            }
            catch (NoAlertPresentException e)
            {
                return false;
            }
            return true;
        }

        [Test]
        public void Implicit_Wait_1()
        {
            
            IWebElement link = driver.FindElement(By.PartialLinkText("Enabled and d"));
            link.Click();
            //Thread.Sleep(3000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement inputField = driver.FindElement(By.Id("input"));
            inputField.SendKeys("Prueba Text");

        }

        [Test]
        public void Implicit_Wait_2()
        {
            
            IWebElement link = driver.FindElement(By.PartialLinkText("Enabled"));
            link.Click();
            Thread.Sleep(3000); // Mala practica es el uso Thread
            IWebElement inputField = driver.FindElement(By.Id("input"));
            inputField.SendKeys("Prueba Text");

        }

        [Test]
        public void Explicit_Wait()
        {            
            driver.Url = "https://www.google.com";
            //IWebElement fieldText = driver.FindElement(By.Name("Name")); // Identificar un webElement y tener una variable para hacer mas de una accion.
            //fieldText.SendKeys("cheese" + Keys.Enter);

            driver.FindElement(By.Name("q")).SendKeys("cheese" + Keys.Enter); // si no vas a usar la variable mas de una vez, utilizar este formato
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            IWebElement firstResult = wait.Until(e => e.FindElement(By.XPath("//a/h3")));
            firstResult.Click();

            Console.WriteLine(firstResult.Text);
        }

        [Test]
        public void Explicit_1()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement autocompletLink = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.PartialLinkText("Autocomplet")));
            autocompletLink.Click();
        }

        [Test]
        public void Exception_2()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement autocompletLink = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.PartialLinkText("Autocomplet")));
            autocompletLink.Click();
        }

        [Test]
        public void Exception_TryCath_Test()
        {
            if (isElementFound("Autocompletasdsdsd",2))
            {
                IWebElement autocompletLink = driver.FindElement(By.PartialLinkText("asdjasd"));
                autocompletLink.Click();
            }

        }


        public bool IsElementFoundPartialLinkText(string partialLink)
        {
            try
            {
                driver.FindElement(By.PartialLinkText(partialLink));
                return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }


        public bool IsElementFoundById(string id)
        {
            try
            {
                driver.FindElement(By.Id(id));
                return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
        }

        public bool isElementFound(string localizador, int tipo)
        {
            try
            {

                switch (tipo)
                {
                    case 1:
                        driver.FindElement(By.Id(localizador));                        
                        break;
                    case 2:
                        driver.FindElement(By.LinkText(localizador));
                        break;
                    case 3:
                        driver.FindElement(By.PartialLinkText(localizador));
                        break;
                    case 4:
                        driver.FindElement(By.Name(localizador));
                        break;
                    default:                                          
                        driver.FindElement(By.XPath(localizador));
                        break;
                }
                return true;
            }catch(NoSuchElementException e)
            {
                return false;
            }
        }


        [Test]
        public void Formulario_Test()
        {
            IWebElement link = driver.FindElement(By.LinkText("Complete Web Form"));
            link.Click();

            // Localizar los webelement de la pagina
            IWebElement nameTextField = driver.FindElement(By.Id("first-name"));
            IWebElement lasNameTextField = driver.FindElement(By.Id("last-name"));
            IWebElement jobTitleTextField = driver.FindElement(By.Id("job-title"));
            IWebElement levelEducationRbt = driver.FindElement(By.Id("radio-button-2"));
            IWebElement sexCmb = driver.FindElement(By.Id("checkbox-1"));
            IWebElement yearsDd = driver.FindElement(By.Id("select-menu"));
            IWebElement BirthDate = driver.FindElement(By.Id("datepicker"));


            nameTextField.SendKeys("Jorge Enrique");
            lasNameTextField.SendKeys("Villavicencio Antunez");
            jobTitleTextField.SendKeys("Ingeniero de Software");

            levelEducationRbt.Click();
            sexCmb.Click();

            SelectElement select = new SelectElement(yearsDd);
            select.SelectByIndex(3);


            BirthDate.SendKeys("27/10/1992");
            

        }

    }
}
