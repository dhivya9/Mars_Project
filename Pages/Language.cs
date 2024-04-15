using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Marsproject.Pages
{
    public class Language

    { 
        //locators

        public By Addnew = By.XPath("//*[contains(text(),'Add New')]");
      
        public By language = By.Name("name");
       
        public By level = By.Name("level");
       
        public By basic = By.XPath("// *[@value='Basic']");
       
        public By coversational = By.XPath("// *[@value='Conversational']");

        public By fluent = By.XPath("// *[@value='Fluent']");

        public By native = By.XPath("// *[@value='Native/Bilingual']");

        public By add = By.XPath("// *[@value='Add']");
        
        public By cancel = By.XPath("// *[@value='Cancel']");
       
        public By update = By.XPath("//*[@value='Update']");

        public By Delete= By.XPath("//div[@data-tab='first']//tbody[1]/tr/td[3]/span[2]/i");

        public By Edit = By.XPath("//div[@data-tab='first']//tbody[last()]/tr/td[3]/span[1]/i");

        public By Edit_data= By.XPath("//*[contains(text(),'German')]");





        //First language
        public void Firstlanguagemethod(IWebDriver driver, string language1)
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
          
             driver.FindElement(Addnew).Click();

            driver.FindElement(language).SendKeys(language1);

            driver.FindElement(level).Click();

            driver.FindElement(fluent).Click();

            driver.FindElement(add).Click();
           
        }
        //Second Language
        public void secondlanguagemethod(IWebDriver driver, string language2)
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);

            driver.FindElement(Addnew).Click();

            driver.FindElement(language).SendKeys(language2);

            driver.FindElement(level).Click();

            driver.FindElement(coversational).Click();

            driver.FindElement(add).Click();

        }
        //Third Language
        public void thirdlanguagemethod(IWebDriver driver, string language3)
        {


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            driver.FindElement(Addnew).Click();

            driver.FindElement(language).SendKeys(language3);

            driver.FindElement(level).Click();

            driver.FindElement(native).Click();

            driver.FindElement(add).Click();

        }
        //Fourth Language
        public void fourthlangaugemethod(IWebDriver driver, string language4)
        {
           

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);

            driver.FindElement(Addnew).Click();

            driver.FindElement(language).SendKeys(language4);

            driver.FindElement(level).Click();

            driver.FindElement(basic).Click();

            driver.FindElement(add).Click();

        }
        //Validate Add New Button
        public void Validateaddnewbutton(IWebDriver driver)
        {

            try
            {
                driver.FindElement(Addnew).Click();
                

            }
            catch (StaleElementReferenceException e)
            {
                Console.WriteLine("Can't add more than 4 values");
            }
        }
       //Edit Record
        public void Editfield(IWebDriver driver,string newlanguage)
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            driver.FindElement(Edit).Click();
            driver.FindElement(language).Clear();
            driver.FindElement(language).SendKeys(newlanguage);
        }
        public void levelfield(IWebDriver driver,string levels)
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
          
            SelectElement selectedLevel = new SelectElement(driver.FindElement(level));
            selectedLevel.SelectByValue(levels);
            driver.FindElement(update).Click();
        }

        public string Validate_Edit(IWebDriver driver)
            {
            string validatedata=driver.FindElement(Edit_data).Text;
            return validatedata;
        }
        //Delete Record
        public void Cancel(IWebDriver driver)
        {
            driver.FindElement(Edit).Click();
            driver.FindElement(cancel).Click();
        }
        public void delete(IWebDriver driver)
        {
            driver.FindElement(Delete).Click();



        }
    }


}

