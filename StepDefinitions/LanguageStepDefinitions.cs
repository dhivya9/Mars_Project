using Marsproject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Marsproject.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions 

    {
        
        Language language = new Language();

        public IWebDriver driver;


        public LanguageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By Edit_data = By.XPath("//*[contains(text(),'German')]");

        

        [Given(@"User able to signin the Mars portal")]
        public void GivenUserAbleToSigninTheMarsPortal()
        {
            Console.WriteLine("User login the succesfully");
        }

        [When(@"user able to enter their language'([^']*)''([^']*)''([^']*)''([^']*)'")]
        public void WhenUserAbleToEnterTheirLanguage(string language1,string language2,string language3,string language4)
        {
            language.Firstlanguagemethod(driver, language1);    
            language.secondlanguagemethod(driver, language2);   
            language.thirdlanguagemethod(driver, language3);
            language.fourthlangaugemethod(driver, language4);

        }

        [Then(@"verify user can able add more than four values")]
        public void ThenVerifyUseerCanAbleAddMoreThanFourValues()
        {
            language.Validateaddnewbutton(driver);
           
        }

        //Update

        [Given(@"User able to edit the language filed'([^']*)'")]
        public void GivenUserAbleToEditTheLanguageFiled(string newlanguage)
        {
            language.Editfield(driver, newlanguage);
        }

        [When(@"User able to edit the levels'([^']*)'")]
        public void WhenUserAbleToEditTheLevels(string levels)
        {
            language.levelfield(driver, levels);
        }


        [Then(@"verify the both fields update successfully")]
        public void ThenVerifyTheBothFieldsUpdateSuccessfully()
        {
            string validatedata = driver.FindElement(Edit_data).Text;
            Assert.That(validatedata, Is.EqualTo("German has been updated to your languages"));
            Console.WriteLine(validatedata);

        }


        //Delete

        [Given(@"User able to give cancel from edit")]
        public void GivenUserAbleToGiveCancelFromEdit()
        {
            language.Cancel(driver);
        }

        [Given(@"User able to delete the record")]
        public void GivenUserAbleToDeleteTheRecord()
        {
            language.delete(driver);
        }

        


    }
}
