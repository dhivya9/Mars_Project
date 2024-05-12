using Marsproject.Hooks;
using Marsproject.Pages;
using Marsproject.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V121.DOM;
using System;
using TechTalk.SpecFlow;
using static NUnit.Framework.Constraints.Tolerance;

namespace Marsproject.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinition

    {
        public IWebDriver driver;
        Language language;

        public LanguageStepDefinition(IWebDriver driver)
        {
            this .driver = driver;
            language = new Language (driver);
        }
      
       
        [Given(@"Delete all before adding new langauge")]
        public void GivenDeleteAllBeforeAddingNewLangauge()
        {

            language.cleanup();
        }

        [Given(@"user able to enter their language'([^']*)''([^']*)''([^']*)''([^']*)' and levels")]
        public void GivenUserAbleToEnterTheirLanguageAndLevels(string language1, string language2, string language3, string language4)
        {
            language.Firstlanguagemethod( language1);
            language.secondlanguagemethod( language2);
            language.thirdlanguagemethod(language3);
            language.fourthlangaugemethod(  language4);
        }


        [Then(@"verify user can able add more than four values")]
        public void ThenVerifyUseerCanAbleAddMoreThanFourValues()
        {
            language.Validateaddnewbutton();
           
        }

        //Update

        [Given(@"User able to edit the language filed'([^']*)''([^']*)'")]
        public void GivenUserAbleToEditTheLanguageFiled(string newlanguage, string levels)
        {
            language.Addingnewfieldtoedit();
            language.Editfield(newlanguage);
            language.levelfield(levels);

        }

        [Then(@"verify the both fields update successfully")]
        public void ThenVerifyTheBothFieldsUpdateSuccessfully()
        {
            string validatedata = driver.FindElement(By.XPath("//*[contains(text(),'German')]")).Text;
            Assert.That(validatedata, Is.EqualTo("German has been updated to your languages"));
            Console.WriteLine(validatedata);

        }

        //Delete

        [Given(@"User able to delete the record'([^']*)''([^']*)'")]
        public void GivenUserAbleToDeleteTheRecord(string Deletelanguage, string levels)
        {
            language.delete(Deletelanguage, levels);
        }

        [Given(@"User able to add the language and levels as null'([^']*)'")]
        public void GivenUserAbleToAddTheLanguageAndLevelsAsNull(string Addlanguage)
        {
            language.Add_language_and_level_asnull(Addlanguage);
        }

        [Then(@"User able to see Error notification")]
        public void ThenUserAbleToSeeErrorNotification()
        {
            string Notification = language.Error_notification();
            Console.WriteLine(Notification);
        }

        [Given(@"User able to enter lanaguges  with Special Character'([^']*)'")]
        public void GivenUserAbleToEnterLanagugesWithSpecialCharacter(string speciallanguage)
        {
           language.special_character(speciallanguage);
            string Notification = language.Error_notification();
            Console.WriteLine(Notification);
        }

        [Given(@"User try to add same langauge twice'([^']*)''([^']*)'")]
        public void GivenUserTryToAddSameLangaugeTwice(string Languages, string levels)
        {
           language.Adding_Same_Langaugeandlevels_twice(Languages, levels);
           string Notification = language.Warning_Notification_adding_samelangaugeagain();
            Console.WriteLine(Notification);
        }

        [Then(@"User able to see the warning notification")]
        public void ThenUserAbleToSeeTheWarningNotification()
        {
            string Notification = language.Warning_Notification_adding_samelangaugeagain();
            Console.WriteLine(Notification);
        }

        [Given(@"User able to add language as null '([^']*)''([^']*)'")]
        public void GivenUserAbleToAddLanguageAsNull(string Languages, string levels)
        {
            language.languageasnull(Languages, levels);
        }


    }
}
