using System;
using NUnit.Framework;
using Selenium.BasesClass;
using Selenium.PagesObject;

namespace Selenium.Test
{

    public class WelcomeTest : BasesTest
	{
        private WelcomePage _WelcomePage;
        
        [Test(Description = "Caso Link Autocomplete")]
        public void Test_autocomplete_Click()
        {
            _WelcomePage = new WelcomePage(driver);
            _WelcomePage.click_autocomplete_link();
        }

        [Test(Description = "Caso Link Buttons")]
        public void Test_click_buttons_link()
        {
            _WelcomePage = new WelcomePage(driver);
            _WelcomePage.click_buttons_link();
        }
    }
}

