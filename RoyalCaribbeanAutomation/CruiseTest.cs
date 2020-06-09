using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RoyalCaribbeanAutomation.Base;
using RoyalCaribbeanAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoyalCaribbeanAutomation
{
    class CruiseTest : WebDriverWrapper
    {
        [Test]
        public void ExploreCruiseTest()
        {
            
            DashBoardPage dashBoardPage = new DashBoardPage(driver);
            dashBoardPage.ClickOnHambergerMenu();
            dashBoardPage.ClickOnPlanCruise();
            dashBoardPage.ClickOnFindCruise();

            CruisePage cruisePage = new CruisePage(driver);
            cruisePage.WaitforPresenceOfSamplerCruise();
            cruisePage.ClickOnSamplerCruise();
            Thread.Sleep(3000);
            cruisePage.ClickOnViewItineraryDetails();

            //get no of rows
            IWebElement tableEle = driver.FindElement(By.XPath("//table[contains(@class,'product-view-itinerary-overview__table')]"));
            ReadOnlyCollection<IWebElement> rowEles = driver.FindElements(By.XPath("//table[@class='product-view-itinerary-overview__table']/tbody/tr"));
            int noOfrow = rowEles.Count;

            //get DayandPort text
            for (int i = 1; i <= noOfrow - 1; i++)
            {
                IWebElement row = rowEles[i];

                string day = driver.FindElement(By.XPath("//table[@class='product-view-itinerary-overview__table']/tbody/tr[" + i + "]/td[1]")).Text;
                string port = driver.FindElement(By.XPath("//table[@class='product-view-itinerary-overview__table']/tbody/tr[" + i + "]/td[2]/div[1]")).Text;

            }

            //Couldn't do assertion


        }
    }
}
