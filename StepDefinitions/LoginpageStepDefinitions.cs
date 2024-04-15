using Marsproject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Marsproject.StepDefinitions
{
    [Binding]
    public class LoginpageStepDefinitions:Commondriver
    {
       

        public LoginpageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
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

            Loginpage loginpage = new Loginpage();
            loginpage.Loginwith_INvalid_cerdentials(driver, Email_ID, Password);

        }


    }
}
