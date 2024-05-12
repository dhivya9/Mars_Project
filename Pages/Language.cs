using Marsproject.Hooks;
using Marsproject.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Marsproject.Pages
{
    public class Language : NewCommondriver

    {
        public Language(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void cleanup()
        {

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
        //First language
        public void Firstlanguagemethod(string language1)
        {


            Wait.WaitToBeClickable(driver, "Xpath", "Addnew", 20);
            IWebElement Addnew = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
            Addnew.Click();

            Wait.WaitToBeVisible(driver, "name", "language", 20);
            IWebElement langaugess = driver.FindElement(By.Name("\"name\""));
            langaugess.SendKeys(language1);

            IWebElement Levels = driver.FindElement(By.Name("level"));
            Levels.Click();

            IWebElement FluentLevel = driver.FindElement(By.XPath("// *[@value='Fluent']"));
            FluentLevel.Click();

            IWebElement AddButton = driver.FindElement(By.XPath("// *[@value='Add']"));
            AddButton.Click();

        }
        //Second Language
        public void secondlanguagemethod(string language2)
        {


            Wait.WaitToBeClickable(driver, "Xpath", "Addnew", 20);
            IWebElement Addnew = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
            Addnew.Click();


            Wait.WaitToBeVisible(driver, "name", "language", 20);
            IWebElement langaugess = driver.FindElement(By.Name("\"name\""));
            langaugess.SendKeys(language2);

            IWebElement Levels = driver.FindElement(By.Name("level"));
            Levels.Click();

            IWebElement CoversationalLevel = driver.FindElement(By.XPath("// *[@value='Conversational']"));
            CoversationalLevel.Click();

            IWebElement AddButton = driver.FindElement(By.XPath("// *[@value='Add']"));
            AddButton.Click();

        }
        //Third Language
        public void thirdlanguagemethod(string language3)
        {



            Wait.WaitToBeClickable(driver, "Xpath", "Addnew", 20);
            IWebElement Addnew = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
            Addnew.Click();

            Wait.WaitToBeVisible(driver, "name", "language", 20);
            IWebElement langaugess = driver.FindElement(By.Name("\"name\""));
            langaugess.SendKeys(language3);

            IWebElement Levels = driver.FindElement(By.Name("level"));
            Levels.Click();

            IWebElement Nativelevel = driver.FindElement(By.XPath("// *[@value='Native/Bilingual']"));
            Nativelevel.Click();

            IWebElement AddButton = driver.FindElement(By.XPath("// *[@value='Add']"));
            AddButton.Click();


        }
        //Fourth Language
        public void fourthlangaugemethod(string language4)
        {


            Wait.WaitToBeClickable(driver, "Xpath", "Addnew", 20);

            IWebElement Addnew = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
            Addnew.Click();
            Wait.WaitToBeVisible(driver, "name", "language", 20);
            IWebElement langaugess = driver.FindElement(By.Name("\"name\""));
            langaugess.SendKeys(language4);
            IWebElement Levels = driver.FindElement(By.Name("level"));
            Levels.Click();

            IWebElement Basiclevel = driver.FindElement(By.XPath("// *[@value='Basic']"));
            Basiclevel.Click();
            IWebElement AddButton = driver.FindElement(By.XPath("// *[@value='Add']"));
            AddButton.Click();


        }
        //Validate Add New Button
        public void Validateaddnewbutton()
        {

            try
            {
                IWebElement Addnew = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
                Addnew.Click();

            }
            catch (StaleElementReferenceException e)
            {
                Console.WriteLine("Can't add more than 4 values");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Can't add more than 4 values");
            }
        }

        //Edit Record
        public void Addingnewfieldtoedit()
        {
            Wait.WaitToBeClickable(driver, "Xpath", "Addnew", 20);

            IWebElement Addnew = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
            Addnew.Click();
            Wait.WaitToBeVisible(driver, "name", "language", 20);
            IWebElement langaugess = driver.FindElement(By.Name("\"name\""));
            langaugess.SendKeys("Tamil");

            IWebElement Levels = driver.FindElement(By.Name("level"));
            Levels.Click();

            IWebElement Basiclevel = driver.FindElement(By.XPath("// *[@value='Basic']"));
            Basiclevel.Click();
            IWebElement AddButton = driver.FindElement(By.XPath("// *[@value='Add']"));
            AddButton.Click();
        }
        public void Editfield(string newlanguage)
        {

            Wait.WaitToBeClickable(driver, "Xpath", "Edit", 30);
            IWebElement EditButton = driver.FindElement(By.XPath("//div[@data-tab='first']//tbody[last()]/tr/td[3]/span[1]/i"));
            EditButton.Click();
            IWebElement langaugess = driver.FindElement(By.Name("\"name\""));
            langaugess.Clear();
            langaugess.SendKeys(newlanguage);

        }
        public void levelfield(string levels)
        {


            Wait.WaitToBeClickable(driver, "Xpath", "Edit", 30);

            SelectElement selectedLevel = new SelectElement(driver.FindElement(By.Name("level")));
            selectedLevel.SelectByValue(levels);
            IWebElement Updatebutton = driver.FindElement(By.XPath("//*[@value='Update']"));
            Updatebutton.Click();
        }

        public string Validate_Edit()
        {
            string validatedata = driver.FindElement(By.XPath("//*[contains(text(),'German')]")).Text;
            return validatedata;
        }

        //Delete Record

        public void delete(string Deletelanguage, string levels)
        {
            Wait.WaitToBeClickable(driver, "Xpath", "Addnew", 20);

            IWebElement Addnew = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
            Addnew.Click();
            Wait.WaitToBeVisible(driver, "name", "language", 20);
            IWebElement langaugess = driver.FindElement(By.Name("\"name\""));
            langaugess.SendKeys(Deletelanguage);

            SelectElement selectedLevel = new SelectElement(driver.FindElement(By.Name("level")));
            selectedLevel.SelectByValue(levels);
            IWebElement AddButton = driver.FindElement(By.XPath("// *[@value='Add']"));
            AddButton.Click();

            Wait.WaitToBeClickable(driver, "Xpath", "Delete", 20);
            IWebElement Delete = driver.FindElement(By.XPath("By.XPath(\"//div[@data-tab='first']//tbody[1]/tr/td[3]/span[2]/i"));
            Delete.Click();
        }

        public void Add_language_and_level_asnull(string Addlanguage)

        {
            IWebElement Addnew = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
            Addnew.Click();
            Wait.WaitToBeVisible(driver, "name", "language", 20);
            IWebElement langaugess = driver.FindElement(By.Name("\"name\""));
            langaugess.SendKeys(Addlanguage);
            IWebElement AddButton = driver.FindElement(By.XPath("// *[@value='Add']"));
            AddButton.Click();


        }
        public string Error_notification()
        {
            string Errornotification = driver.FindElement(By.XPath("/html/body/div[1]")).Text;
            return Errornotification;

        }

        public void special_character(string speciallanguage)
        {

            IWebElement Addnew = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
            Addnew.Click();

            Wait.WaitToBeVisible(driver, "name", "languagess", 20);
            IWebElement langaugess = driver.FindElement(By.XPath("//*[@placeholder='Add Language']"));
            langaugess.SendKeys(speciallanguage);

            IWebElement Levels = driver.FindElement(By.Name("level"));
            Levels.Click();

            IWebElement Nativelevel = driver.FindElement(By.XPath("// *[@value='Native/Bilingual']"));
            Nativelevel.Click();

            IWebElement AddButton = driver.FindElement(By.XPath("// *[@value='Add']"));
            AddButton.Click();

        }
        public void Adding_Same_Langaugeandlevels_twice(string Languages, string levels)
        {
            IWebElement Addnew = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
            Addnew.Click();

            Wait.WaitToBeVisible(driver, "name", "language", 20);
            IWebElement langaugess = driver.FindElement(By.XPath("//*[@placeholder='Add Language']"));
            langaugess.SendKeys(Languages);

            SelectElement selectedLevel = new SelectElement(driver.FindElement(By.Name("level")));
            selectedLevel.SelectByValue(levels);

            IWebElement AddButton = driver.FindElement(By.XPath("// *[@value='Add']"));
            AddButton.Click();

            Thread.Sleep(2000);

            IWebElement Addnew1 = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
            Addnew1.Click();

            Thread.Sleep(3000);
            IWebElement langaugess1 = driver.FindElement(By.XPath("//*[@placeholder='Add Language']"));
            langaugess1.SendKeys("English");

            IWebElement Levels = driver.FindElement(By.Name("level"));
            Levels.Click();

            IWebElement FluentLevel = driver.FindElement(By.XPath("// *[@value='Fluent']"));
            FluentLevel.Click();

            IWebElement AddButton1 = driver.FindElement(By.XPath("// *[@value='Add']"));

            AddButton1.Click();


        }
        public string Warning_Notification_adding_samelangaugeagain()
        {
            string Errornotification = driver.FindElement(By.XPath("/html/body/div[1]")).Text;
            return Errornotification;

        }

        public void languageasnull(String Languages, string levels)
        {
            IWebElement Addnew = driver.FindElement(By.XPath("//*[contains(text(),'Add New')]"));
            Addnew.Click();

            Wait.WaitToBeVisible(driver, "name", "language", 20);
            IWebElement langaugess = driver.FindElement(By.XPath("//*[@placeholder='Add Language']"));
            langaugess.SendKeys(Languages);

            SelectElement selectedLevel = new SelectElement(driver.FindElement(By.Name("level")));
            selectedLevel.SelectByValue(levels);

            IWebElement AddButton = driver.FindElement(By.XPath("// *[@value='Add']"));
            AddButton.Click();
        }
    }


}

