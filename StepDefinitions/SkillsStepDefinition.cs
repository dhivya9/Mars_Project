using Marsproject.Pages;
using Marsproject.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Marsproject.StepDefinitions
{
    [Binding]
    public class SkillsStepDefinitions
    {
        public IWebDriver driver;
        Skills skills;

        public SkillsStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            skills = new Skills(driver);
        }

        [Given(@"Clean all skills before adding new skills in the list")]
        public void GivenCleanAllSkillsBeforeAddingNewSkillsInTheList()
        {
           skills.cleanup();
        }



        [Given(@"User able to enter their known skills'([^']*)'")]
        public void GivenUserAbleToEnterTheirKnownSkills(string Skills)
        {
            skills.EnterSkills(Skills);
        }

        [Then(@"User able to enter their skill levels'([^']*)'")]
        public void ThenUserAbleToEnterTheirSkillLevels(string Levels)
        {
            skills.Enterlevels(  Levels);
        }

        [Then(@"validate skills and levels are added correctly'([^']*)'")]
        public void ValidateSkillsAndLevelsAreAddedCorrectly(string Skills)
        {
            string notification = skills.Validate_skills(Skills);

            string Message = Skills + " has been added to your skills";
           
             Assert.That(notification, Is.EqualTo(Message), notification);
            Console.WriteLine(notification);
      

        }
        //Edit
        [Given(@"User able to Edit the Skill field'([^']*)'")]
        public void GivenUserAbleToEditTheSkillField(string NewSkill)
        {
            skills.Edit_skills(NewSkill);
        }

        [Then(@"User able to Edit the levels field'([^']*)'")]
        public void ThenUserAbleToEditTheLevelsField(string Newlevel)
        {
            skills.Edit_Levels(Newlevel);
        }
        
        [Then(@"Validate Skills and levels field are updated correctly'([^']*)'")]
        public void ThenValidateSkillsAndLevelsFieldAreUpdatedCorrectly(string NewSkill)
        {
            skills.validateEditskill( NewSkill);
            string notification = skills.validateEditskill( NewSkill);
            //string Message = NewSkill+ " has been updated to your skills";
            //Assert.That(notification, Is.EqualTo(Message), notification);
            Console.WriteLine(notification);
        }
        //Delete
        [Given(@"User able to delete the skills and levels they entered on the page'([^']*)''([^']*)'")]
        public void GivenUserAbleToDeleteTheSkillsAndLevelsTheyEnteredOnThePage(string Skills, string Levels)
        {
            skills.Deleteskillsrecord(Skills, Levels);
        }

        [Then(@"User will get delete notification")]
        public void ThenUserWillGetDeleteNotification()
        {
            String Delete_Notification = skills.Delete_Notification();
            Console.WriteLine(Delete_Notification);
        }

        [Given(@"User try to enter skills filed as Null and levels'([^']*)''([^']*)'")]
        public void GivenUserTryToEnterSkillsFiledAsNullAndLevels(string Skills, string Levels)
        {
            skills.Nullvalueinskillfiled(Skills, Levels);
        }
        [Then(@"User see  the Warning notification")]
        public void ThenUserSeeTheWarningNotification()
        {
            string Skill_Notification=skills.Warning_Message();
            Console.WriteLine(Skill_Notification);  
        }

        [Given(@"User try add skills without levels'([^']*)'")]
        public void GivenUserTryAddSkillsWithoutLevels(string Skills)
        {
            skills.Addskillswithoutlivels(Skills);
        }

        [Then(@"User seethe Warning notification")]
        public void ThenUserSeetheWarningNotification()
        {
            string levelwarning=skills.levelwarningmessage();
            Console.WriteLine(levelwarning);    
        }

        [Given(@"User try to add same skills again and again'([^']*)''([^']*)'")]
        public void GivenUserTryToAddSameSkillsAgainAndAgain(string Skills, string Levels)
        {
           skills.Adding_samelanguage_twice (Skills, Levels);
        }

        [Then(@"User see the warning message")]
        public void ThenUserSeeTheWarningMessage()
        {
            string warningmessage=skills.Warningmessage();
            Console.WriteLine(warningmessage);
        }

    }
}
