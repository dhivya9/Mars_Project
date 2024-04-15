using Marsproject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Marsproject.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions:Commondriver
    {
        Skills skill = new Skills();

       
        public SkillsStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"User able to enter their known skills'([^']*)'")]
        public void GivenUserAbleToEnterTheirKnownSkills(string Skills)
        {
            skill.EnterSkills(driver, Skills);
        }

        [Then(@"User able to enter their skill levels'([^']*)'")]
        public void ThenUserAbleToEnterTheirSkillLevels(string Levels)
        {
            skill.Enterlevels( driver, Levels);
        }

        [Then(@"validate skills and levels are added correctly'([^']*)'")]
        public void ValidateSkillsAndLevelsAreAddedCorrectly(string Skills)
        {
            string notification = skill.Validate_skills(driver, Skills);

            string Message = Skills + " has been added to your skills";
           
             Assert.That(notification, Is.EqualTo(Message), notification);
            Console.WriteLine(notification);
      

        }
        //Edit
        [Given(@"User able to Edit the Skill field'([^']*)'")]
        public void GivenUserAbleToEditTheSkillField(string NewSkill)
        {
            skill.Edit_skills(driver, NewSkill);
        }

        [Then(@"User able to Edit the levels field'([^']*)'")]
        public void ThenUserAbleToEditTheLevelsField(string Newlevel)
        {
            skill.Edit_Levels(driver, Newlevel);
        }
        
        [Then(@"Validate Skills and levels field are updated correctly'([^']*)'")]
        public void ThenValidateSkillsAndLevelsFieldAreUpdatedCorrectly(string NewSkill)
        {
            skill.validateEditskill(driver, NewSkill);
            string notification = skill.validateEditskill(driver, NewSkill);
            string Message = NewSkill+ " has been updated to your skills";
            Assert.That(notification, Is.EqualTo(Message), notification);
            Console.WriteLine(notification);
        }
        //Delete
        [Given(@"User able to delete the skills and levels they entered on the page")]
        public void GivenUserAbleToDeleteTheSkillsAndLevelsTheyEnteredOnThePage()
        {
           skill.Deleteskillsrecord(driver);
        }



    }
}
