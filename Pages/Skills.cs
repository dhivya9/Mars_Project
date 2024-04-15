using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Marsproject.Pages
{
    public class Skills:Commondriver
    {
        public By Skills_button = By.XPath("//*[contains(text(),'Skills')]");

        public By Addnew = By.XPath("(//div[@class='ui teal button'])[1]");


        public By Skill_levels = By.XPath("//*[@class='ui fluid dropdown']");

        public By Skill_name = By.XPath("//*[@placeholder='Add Skill']");

        public By Add_button = By.XPath("//*[@value='Add']");

        public By Popup_Message = By.XPath("//div[@class='ns-box-inner']");

        public By Edit_button= By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[3]/span[1]");

        public By update_button = By.XPath("//*[@value='Update']");

        public By Delete_button = By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[3]/span[2]");



        public void EnterSkills(IWebDriver driver,string Skills)
        {
            Wait.WaitToBeClickable(driver, "Xpath","Skills_button", 20);
            driver.FindElement(Skills_button).Click();
            Wait.WaitToBeVisible(driver, "Xpath", "Addnew", 20);
            driver.FindElement(Addnew).Click();

            driver.FindElement(Skill_name).SendKeys(Skills);


        }
        public void Enterlevels(IWebDriver driver,string Levels)
        {
            Wait.WaitToBeVisible(driver, "Name", "Skill_levels", 20);
            SelectElement selectedLevel = new SelectElement(driver.FindElement(Skill_levels));
            selectedLevel.SelectByValue(Levels);
            driver.FindElement(Add_button).Click();
        }

        public  string Validate_skills(IWebDriver driver,string skills)
        {
            string successMessage = driver.FindElement(Popup_Message).Text;
            return successMessage;

        }
        public void Edit_skills(IWebDriver driver,string NewSkill)
        {

            driver.FindElement(Skills_button).Click();
            //it.WaitToBeVisible(driver, "Xpath", "Edit_button", 20);
            driver.FindElement(Edit_button).Click();

            driver.FindElement(Skill_name).Clear();
            driver.FindElement(Skill_name).SendKeys(NewSkill);

        }

        public void Edit_Levels(IWebDriver driver,string Newlevel)
        {
            SelectElement selectedLevel = new SelectElement(driver.FindElement(Skill_levels));
            selectedLevel.SelectByValue(Newlevel);
            driver.FindElement(update_button).Click();  
        }

        public string validateEditskill(IWebDriver driver, string Newskill)
        {
           string EditMessage=driver.FindElement(Popup_Message).Text; return EditMessage;   
        }

        public void Deleteskillsrecord(IWebDriver driver) 
        {
            driver.FindElement(Skills_button).Click();
            driver.FindElement(Delete_button).Click();

        }
    }



}
