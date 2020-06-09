using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCaribbeanAutomation.Pages
{
    class DashBoardPage
    {
        private IWebDriver driver;
        private By hamBergerMenuLocator = By.XPath("//div[@class='headerMainToolbar__menu__icon']");
        private By experienceLocator = By.XPath("//span[text()='The Experience ']");
        private By ourShipsLocator = By.XPath("//span[text()='Our Ships']");
        private By planCruiseLocator = By.XPath("//span[contains(text(),'Plan A Cruise')] ");
        private By findCruiseLoactor = By.XPath("//span[contains(text(),'Find A Cruise')] ");
        private By signInLocator = By.XPath("(//span[text()='Sign In'])[1]");


        public DashBoardPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool CheckPresenceOfWhaleWatchingLink()
        {
            ReadOnlyCollection<IWebElement> linksEles = driver.FindElements(By.TagName("a"));

            int noOfLinks = linksEles.Count;

            bool iswhaleElePresent = false;
            for (int i = 0; i < noOfLinks; i++)
            {
                IWebElement ele = linksEles[i];
                string innerText = ele.Text;

                if (innerText.Equals("whale watching"))
                {
                    iswhaleElePresent = true;
                    break;
                }
            }
            return iswhaleElePresent;
        }

        public void WaitForHambergerMenu()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Until(x => x.FindElement(hamBergerMenuLocator));
        }

        public void ClickOnHambergerMenu()
        {
            driver.FindElement(hamBergerMenuLocator).Click();
        }
        public void ClickOnExperience()
        {
            driver.FindElement(experienceLocator).Click();
        }

        public void ClickOnOurShips()
        {
            driver.FindElement(ourShipsLocator).Click();
        }

        public void ClickOnPlanCruise()
        {
            driver.FindElement(planCruiseLocator).Click();
        }

        public void ClickOnFindCruise()
        {
            driver.FindElement(findCruiseLoactor).Click();
        }

        public void ClickOnSignIn()
        {
            driver.FindElement(signInLocator).Click();
        }
    }

}
