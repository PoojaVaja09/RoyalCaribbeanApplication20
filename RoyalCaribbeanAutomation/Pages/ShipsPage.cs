using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCaribbeanAutomation.Pages
{
    class ShipsPage
    {
        private IWebDriver driver;
        private By rhapsodyOfTheSeasLocator = By.XPath("//p[contains(text(),'Rhapsody of the Seas')]");

        public ShipsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ChooseRhapsodyOfTheSeas()
        {
            driver.FindElement(rhapsodyOfTheSeasLocator).Click();
        }

    }
}
