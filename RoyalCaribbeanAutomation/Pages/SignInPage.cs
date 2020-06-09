using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalCaribbeanAutomation.Pages
{
    class SignInPage
    {
        private IWebDriver driver;
        private By createAnAccountLocator = By.LinkText("Create an account");
        private By firstNameLocator = By.Id("mat-input-3");
        private By lastNameLocator = By.Id("mat-input-4");
        
        private By mayMonthLocator = By.XPath("//span[text()=' May ']");
        
        private By dateLocator = By.XPath("//span[text()=' 4 ']");
        private By yearLocator = By.Id("mat-input-5");
        private By emailAddressLocator = By.Id("mat-input-2");
        private By countryDropdownLocator = By.XPath("//span[@class='mat-select-placeholder ng-tns-c31-11 ng-star-inserted']");
        private By countryTextLocator = By.XPath("//span[text()=' United States ']");
        private By passwordLocator = By.Id("mat-input-6");
        private By securityQuestionDropdownLocator = By.XPath("//span[@class='mat-select-placeholder ng-tns-c31-14 ng-star-inserted']");
        private By securityQuestionLocator = By.XPath("//span[text()=' What elementary school did you go to? ']");
        private By securityAnswerLocator = By.Id("mat-input-7");
        private By checkBoxLocator = By.XPath("//div[@class='mat-checkbox-inner-container mat-checkbox-inner-container-no-side-margin']");
        private By doneButtonLocator = By.XPath("//button[@class='mat-royal-button btn-create']");
        private By myAccountLocator = By.XPath("//span[@class='menu-nav__profile-label']");


        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickOnCreateAccount()
        {
            driver.FindElement(createAnAccountLocator).Click();
        }
        public void SendFirstName(string firstName)
        {
            driver.FindElement(firstNameLocator).SendKeys(firstName);
        }
        public void SendLastName(string lastName)
        {
            driver.FindElement(lastNameLocator).SendKeys(lastName);
        }
        
        public void ChooseMonthAndClick()
        {
            driver.FindElement(By.XPath("//span[@class='mat-select-placeholder ng-tns-c31-7 ng-star-inserted']")).Click();
            driver.FindElement(mayMonthLocator).Click();
        }
                
        public void ChooseDateAndClick()
        {
            driver.FindElement(By.XPath("//span[@class='mat-select-placeholder ng-tns-c31-9 ng-star-inserted']")).Click();
            driver.FindElement(dateLocator).Click();
        }

        public void SendYear(string year)
        {
            
            driver.FindElement(yearLocator).SendKeys(year);
        }
                
        public void ChooseCountryAndClick()
        {
            driver.FindElement(countryDropdownLocator).Click();
            driver.FindElement(countryTextLocator).Click();
        }
        public void SendEmailAddress(string email)
        {
            driver.FindElement(emailAddressLocator).SendKeys(email);
        }
        public void SendPassword(string password)
        {
            driver.FindElement(passwordLocator).SendKeys(password);
        }
        public void ChooseSecurityQuestionAndClick()
        {
            driver.FindElement(securityQuestionDropdownLocator).Click();

            driver.FindElement(securityQuestionLocator).Click();
        }
        public void SendSecurityAnswer(string securityanswer)
        {
            driver.FindElement(securityAnswerLocator).SendKeys(securityanswer);
        }
        public void ClickOnCheckBox()
        {
            driver.FindElement(checkBoxLocator).Click();
        }

        public void ClickOnDoneButton()
        {
            driver.FindElement(doneButtonLocator).Click();
        }

        public string GetMyAccountText()
        {
          string actualValue=driver.FindElement(myAccountLocator).Text;
            return actualValue ;
        }
    }
}
