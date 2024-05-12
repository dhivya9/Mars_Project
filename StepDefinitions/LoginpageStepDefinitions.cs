using Marsproject.Pages;
using Marsproject.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Marsproject.StepDefinitions
{
    [Binding]
    public class LoginpageStepDefinitions:NewCommondriver
    {


        public IWebDriver driver;
        Loginpage loginpage;

        public LoginpageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            loginpage = new Loginpage(driver);
        }

        public By homepage_text = By.XPath("//*[contains(text(),'Mars Logo')]");

        [Given(@"User able to login with valid cerdentials")]
        public void GivenUserAbleToLoginWithValidCerdentials()
        {
           
            String verification_Text = driver.FindElement(homepage_text).Text;
            Assert.That(verification_Text, Is.EqualTo("Mars Logo"));
            Console.WriteLine(verification_Text);
        }

       
        [Given(@"User try to login with invalid EmailID'([^']*)''([^']*)'")]
        public void GivenUserTryToLoginWithInvalidEmailID(string Email_ID, string Password)
        {

           
            loginpage.Loginwith_INvalid_cerdentials( Email_ID, Password);

        }
       
        [Given(@"user try to login with valid username and invalid password'([^']*)''([^']*)'")]
        public void GivenUserTryToLoginWithValidUsernameAndInvalidPassword(string Email_ID, string Password)
        {
            loginpage.validusername_invalidpassword(Email_ID, Password);
        }

        [Then(@"User will get Error Notification")]
        public void ThenUserWillGetErrorNotification()
        {
            string Notification = loginpage.Error_Notification();

            Console.WriteLine(Notification);

        }

        [Given(@"User try to login with invalid username and valid password'([^']*)''([^']*)'")]
        public void GivenUserTryToLoginWithInvalidUsernameAndValidPassword(string Email_ID, string Password)
        {
            loginpage.invalidusername_validpassword(Email_ID, Password);
        }


        [Then(@"User will see the warning notification in Email field")]
        public void ThenUserWillSeeTheWarningNotificationInEmailField()
        {
            string Warning_Message=loginpage.Warning_EMail_ID_Field();
            Console.WriteLine(Warning_Message);
        }
        [Given(@"User keep both username and password field empty and click on Login '([^']*)''([^']*)'")]
        public void GivenUserKeepBothUsernameAndPasswordFieldEmptyAndClickOnLogin(string Email_ID, string Password)
        {
            loginpage.username_password_empty(Email_ID, Password);  
        }

        [Then(@"User will see the warning in username field")]
        public void ThenUserWillSeeTheWarningInUsernameField()
        {
            string Warning_Message = loginpage.Warning_EMail_ID_Field();
            Console.WriteLine(Warning_Message);
        }

        [Then(@"user will see the warning in password field")]
        public void ThenUserWillSeeTheWarningInPasswordField()
        {
            string Password_Notification = loginpage.Error_Notification();
            Console.WriteLine(Password_Notification);

        }


    }
}
