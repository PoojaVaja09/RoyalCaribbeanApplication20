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
   
    class ShipTest:WebDriverWrapper
    {
        

        [Test]
        public void ExploreShipsTest()
        {
            DashBoardPage dashBoardPage = new DashBoardPage(driver);
            bool isWhalePresent= dashBoardPage.CheckPresenceOfWhaleWatchingLink();
            dashBoardPage.WaitForHambergerMenu();
            dashBoardPage.ClickOnHambergerMenu();
            dashBoardPage.ClickOnExperience();
            dashBoardPage.ClickOnOurShips();
            
            ShipsPage shipsPage = new ShipsPage(driver);
            shipsPage.ChooseRhapsodyOfTheSeas();
            
            DeckPlanPage deckPlanPage = new DeckPlanPage(driver);
            deckPlanPage.WaitForDeckPlan();
            deckPlanPage.ClickOnDeckPlans();
            deckPlanPage.WaitForViewEle();
            deckPlanPage.ChangeToDeckEight();
            deckPlanPage.WaitforpresenceofRoyalSuite();

            //Check the presence of "Royal Suite" 
            bool isRoyalSuitePresent=deckPlanPage.CheckPresenceOfRoyalSuite();

            bool isBothPresent = false;
            if(isWhalePresent == true  && isRoyalSuitePresent == true)
            {
                isBothPresent = true;
            }            

            Assert.True(isBothPresent, "Does not meet all requirenment", null);
        }

            
        

        
    }
}
