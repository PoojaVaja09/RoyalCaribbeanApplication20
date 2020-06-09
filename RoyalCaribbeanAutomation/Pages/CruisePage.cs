using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCaribbeanAutomation.Pages
{
    class CruisePage
    {
        private IWebDriver driver;

        private By samplerCruiseLocator = By.XPath("//h3[text()=' Sampler Cruise'][1]");
        private By viewItenaryDetailsLocator=By.XPath("//span[contains(text(),'View Itinerary Details')]");

        public CruisePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitforPresenceOfSamplerCruise()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Until(x => x.FindElement(samplerCruiseLocator));

        }

        public void ClickOnSamplerCruise()
        {
            driver.FindElement(samplerCruiseLocator).Click();
        }

        public void ClickOnViewItineraryDetails()
        {
            driver.FindElement(viewItenaryDetailsLocator).Click();
        }
    }
}
