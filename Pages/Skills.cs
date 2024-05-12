using Marsproject.Support;
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
    public class Skills : NewCommondriver

    {
        public Skills(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void cleanup()
        {
            IWebElement Skills_Button = driver.FindElement(By.XPath("//*[contains(text(),'Skills')]"));
            Skills_Button.Click();

            try
            {
                int num = driver.FindElements(By.XPath("//*[@class=\"remove icon\"]")).Count();
                for (int i = 0; i < num; i++)
                {

                    IWebElement delete = driver.FindElement(By.XPath("//*[@class=\"remove icon\"]"));
                    delete.Click();
                }
            }
            catch (StaleElementReferenceException e)
            {
                Console.WriteLine("No elememt to delete");

            }
            catch (ElementNotInteractableException e)
            {
                Console.WriteLine("No data to delete");
            }


        }
       
        public void EnterSkills(string Skills)
        {
            Wait.WaitToBeClickable(driver, "Xpath", "Skills_button", 20);
            IWebElement Skills_Button = driver.FindElement(By.XPath("//*[contains(text(),'Skills')]"));
            Skills_Button.Click();

            Thread.Sleep(2000);
            IWebElement AddNew_Button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew_Button.Click();

            IWebElement Skills_Name = driver.FindElement(By.XPath("//*[@placeholder='Add Skill']"));
            Skills_Name.SendKeys(Skills);


        }
        public void Enterlevels(string Levels)
        {
            Wait.WaitToBeVisible(driver, "Name", "Skill_levels", 20);
            SelectElement selectedLevel = new SelectElement(driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']")));
            selectedLevel.SelectByValue(Levels);
            IWebElement Add_Button = driver.FindElement(By.XPath("//*[@value='Add']"));
            Add_Button.Click();
        }

        public string Validate_skills(string skills)
        {
            string successMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            return successMessage;

        }
        public void Edit_skills(string NewSkill)
        {

            IWebElement Skills_Button = driver.FindElement(By.XPath("//*[contains(text(),'Skills')]"));
            Skills_Button.Click();

            IWebElement AddNew_Button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew_Button.Click();

            IWebElement Skills_Name = driver.FindElement(By.XPath("//*[@placeholder='Add Skill']"));
            Skills_Name.SendKeys("Dance");

            IWebElement Levels = driver.FindElement(By.Name("level"));
            Levels.Click();

            IWebElement FluentLevel = driver.FindElement(By.XPath("// *[@value='Beginner']"));
            FluentLevel.Click();

            IWebElement Add_Button = driver.FindElement(By.XPath("//*[@value='Add']"));
            Add_Button.Click();

            IWebElement Edit_Button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            Edit_Button.Click();

            IWebElement Newskills_Button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            Newskills_Button.Clear();
            Newskills_Button.SendKeys(NewSkill);


        }

        public void Edit_Levels(string Newlevel)
        {
            SelectElement selectedLevel = new SelectElement(driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']")));
            selectedLevel.SelectByValue(Newlevel);
            IWebElement Update_Button = driver.FindElement(By.XPath("//*[@value='Update']"));
            Update_Button.Click();
        }

        public string validateEditskill(string Newskill)
        {
            string EditMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            return EditMessage;
        }

        public void Deleteskillsrecord(String Skills, String Levels)
        {
            IWebElement Skills_Button = driver.FindElement(By.XPath("//*[contains(text(),'Skills')]"));
            Skills_Button.Click();
            IWebElement AddNew_Button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew_Button.Click();
            IWebElement Skills_Name = driver.FindElement(By.XPath("//*[@placeholder='Add Skill']"));
            Skills_Name.SendKeys(Skills);
            
            SelectElement selectedLevel = new SelectElement(driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']")));
            selectedLevel.SelectByValue(Levels);

            IWebElement Add_Button = driver.FindElement(By.XPath("//*[@value='Add']"));
            Add_Button.Click();

            IWebElement Delete_Button = driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[3]/span[2]"));
            Delete_Button.Click();

        }
        public string Delete_Notification()
        {
            string DeleteMessage = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            return DeleteMessage;
        }

        public void Nullvalueinskillfiled(string Skills,String Levels)
        {
            IWebElement Skills_Button = driver.FindElement(By.XPath("//*[contains(text(),'Skills')]"));
            Skills_Button.Click();
            IWebElement AddNew_Button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew_Button.Click();
            IWebElement Skills_Name = driver.FindElement(By.XPath("//*[@placeholder='Add Skill']"));
            Skills_Name.SendKeys(Skills);

            SelectElement selectedLevel = new SelectElement(driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']")));
            selectedLevel.SelectByValue(Levels);

            IWebElement Add_Button = driver.FindElement(By.XPath("//*[@value='Add']"));
            Add_Button.Click();
        }
        public string Warning_Message()
        {
            string Skill_Warning = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            return Skill_Warning;
        }
        public void Addskillswithoutlivels(string Skills)
        {
            IWebElement Skills_Button = driver.FindElement(By.XPath("//*[contains(text(),'Skills')]"));
            Skills_Button.Click();
            IWebElement AddNew_Button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew_Button.Click();
            IWebElement Skills_Name = driver.FindElement(By.XPath("//*[@placeholder='Add Skill']"));
            Skills_Name.SendKeys(Skills);
            IWebElement Add_Button = driver.FindElement(By.XPath("//*[@value='Add']"));
            Add_Button.Click();

        }
        public string levelwarningmessage()
        {
            string level_warning = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            return level_warning;
        }
        public void Adding_samelanguage_twice(String Skills,String Levels)

        {
            IWebElement Skills_Button = driver.FindElement(By.XPath("//*[contains(text(),'Skills')]"));
            Skills_Button.Click();

            IWebElement AddNew_Button = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew_Button.Click();

            IWebElement Skills_Name = driver.FindElement(By.XPath("//*[@placeholder='Add Skill']"));
            Skills_Name.SendKeys("Music");

            IWebElement Levelss = driver.FindElement(By.Name("level"));
            Levelss.Click();

            IWebElement FluentLevel = driver.FindElement(By.XPath("// *[@value='Beginner']"));
            FluentLevel.Click();

            IWebElement Add_Button = driver.FindElement(By.XPath("//*[@value='Add']"));
            Add_Button.Click();

            IWebElement AddNew_Button1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew_Button1.Click();
           IWebElement Skills_Name1 = driver.FindElement(By.XPath("//*[@placeholder='Add Skill']"));
            Skills_Name1.SendKeys(Skills);

            SelectElement selectedLevel = new SelectElement(driver.FindElement(By.XPath("//*[@class='ui fluid dropdown']")));
            selectedLevel.SelectByValue(Levels);

            IWebElement Add_Button1 = driver.FindElement(By.XPath("//*[@value='Add']"));
            Add_Button1.Click();

        }
        public string Warningmessage()
        {
            string Twoskills_warning = driver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            return Twoskills_warning;
        }
    }
}
