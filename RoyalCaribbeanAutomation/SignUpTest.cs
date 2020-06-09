using NUnit.Framework;
using OpenQA.Selenium;
using RoyalCaribbeanAutomation.Base;
using RoyalCaribbeanAutomation.Pages;
using RoyalCaribbeanAutomation.Utilities;
using System;
using System.Threading;

namespace RoyalCaribbeanAutomation
{
    class SignUpTest:WebDriverWrapper
    {
        public static object[] ValidSignUpSource()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            path = path.Substring(0, path.LastIndexOf("bin"));
            path = new Uri(path).LocalPath;
            path = path + @"TestData\RoyalcaribbeanData.xlsx";

            string currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            object[] main = ExcelUtils.GetSheetIntoObject(path, currentMethodName);

            return main;

        }

        [Test, TestCaseSource("ValidSignUpSource")]
        public void ValidSignUpTest(string firstName, string lastName,string year,string email,string password,string securityAnswer,string expectedValue)
        {   
            DashBoardPage dashBoardPage = new DashBoardPage(driver);
            dashBoardPage.ClickOnSignIn();
                        
            SignInPage signInPage = new SignInPage(driver);
            signInPage.ClickOnCreateAccount();
            signInPage.SendFirstName(firstName);
            signInPage.SendLastName(lastName);
            signInPage.ChooseMonthAndClick();
            signInPage.ChooseDateAndClick();
            signInPage.SendYear(year);
            signInPage.ChooseCountryAndClick();
            Thread.Sleep(2000);
            signInPage.SendEmailAddress(email);
            signInPage.SendPassword(password);
            signInPage.ChooseSecurityQuestionAndClick();
            signInPage.SendSecurityAnswer(securityAnswer);
            signInPage.ClickOnCheckBox();
            
            signInPage.ClickOnDoneButton();

            
            string actualValue = signInPage.GetMyAccountText();

            Assert.AreEqual(expectedValue, actualValue);
            

           


        }
    }
}
