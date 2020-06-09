using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCaribbeanAutomation.Pages
{
    class DeckPlanPage
    {
        private IWebDriver driver;

        private By deckPlanLocator=By.LinkText("DECK PLANS");
        private By deckDropDownLocator=By.Id("deckDropdown");
        private By royalSuiteLocator = By.XPath("//h4[contains(text(),'Royal Suite')]");

        public DeckPlanPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitForDeckPlan()
        {
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait1.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait1.Until(x => x.FindElement(deckPlanLocator));
        }

        public void ClickOnDeckPlans()
        {
            driver.FindElement(deckPlanLocator).Click();
        }

        public void WaitForViewEle()
        {
            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait3.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait3.Until(x => x.FindElement(deckDropDownLocator));
        }

        public void ChangeToDeckEight()
        {
            IWebElement viewEle = driver.FindElement(deckDropDownLocator);
            SelectElement selectView = new SelectElement(viewEle);
            selectView.SelectByText("Deck Eight");
        }

        public void WaitforpresenceofRoyalSuite()
        {
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait2.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait2.Until(x => x.FindElement(royalSuiteLocator));

        }
        public bool CheckPresenceOfRoyalSuite()
        {
            IWebElement royalSuiteEle = driver.FindElement(royalSuiteLocator);
            
            bool isRoyalSuitePresent = false;
            if (royalSuiteEle != null)
            {
                isRoyalSuitePresent = true;
                
            }
            return isRoyalSuitePresent;
        }
        

    }


            

    
}
