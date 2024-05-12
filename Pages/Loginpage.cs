using Marsproject.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Marsproject.Pages
{
    public class Loginpage : NewCommondriver

    {
        public Loginpage(IWebDriver driver)
        {
            this.driver = driver;
        }
        //  public By SignInButton = By.XPath("//*[contains(text(),'Sign')]");

        //public By Email_field = By.Name("email");

        //public By Password_field = By.Name("password");

        //public By Loginbutton = By.XPath("//*[contains(text(),'Login')]");

        public By homepage_text = By.XPath("//*[contains(text(),'Mars Logo')]");

        public By EmailID_field = By.Name("email");


        public void Loginwith_INvalid_cerdentials(string Email_ID, string Password)
        {

            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            IWebElement SignINButton = driver.FindElement(By.XPath("//*[contains(text(),'Sign')]"));
            SignINButton.Click();
            IWebElement Email_filed = driver.FindElement(By.Name("email"));
            Email_filed.SendKeys(Email_ID);
            IWebElement Password_filed = driver.FindElement(By.Name("password"));
            Password_filed.SendKeys(Password);
            IWebElement Login_Button = driver.FindElement(By.XPath("//*[contains(text(),'Login')]"));
            Login_Button.Click();


            if (driver.FindElement(EmailID_field).GetAttribute("email") != "dhivyaglitz23@gmail.com")
            {
                Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
                screenshot.SaveAsFile("C:\\Mars\\Marsproject\\Screenshot\\Image1 " + System.Drawing.Imaging.ImageFormat.Png);
                Console.WriteLine("Invalid E-MailID,Pls refer Screenshot");

            }

        }
        public void validusername_invalidpassword(string Email_ID, string Password)
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            IWebElement SignINButton = driver.FindElement(By.XPath("//*[contains(text(),'Sign')]"));
            SignINButton.Click();
            IWebElement Email_filed = driver.FindElement(By.Name("email"));
            Email_filed.SendKeys(Email_ID);
            IWebElement Password_filed = driver.FindElement(By.Name("password"));
            Password_filed.SendKeys(Password);
            IWebElement Login_Button = driver.FindElement(By.XPath("//*[contains(text(),'Login')]"));
            Login_Button.Click();
        }

        public string Error_Notification()
        {
            string Errornotification = driver.FindElement(By.XPath("/html/body/div[1]")).Text;
            return Errornotification;

        }

        public string Password_Notification()
        {
            String Password_Notification = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/div")).Text;
            return Password_Notification;
        }
        public void invalidusername_validpassword(string Email_ID, string Password)
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            IWebElement SignINButton = driver.FindElement(By.XPath("//*[contains(text(),'Sign')]"));
            SignINButton.Click();
            IWebElement Email_filed = driver.FindElement(By.Name("email"));
            Email_filed.SendKeys(Email_ID);
            IWebElement Password_filed = driver.FindElement(By.Name("password"));
            Password_filed.SendKeys(Password);
            IWebElement Login_Button = driver.FindElement(By.XPath("//*[contains(text(),'Login')]"));
            Login_Button.Click();
        }
        public string  Warning_EMail_ID_Field()
        {
            IWebElement Email_Notification_field = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/div"));
            return Email_Notification_field.Text;
        }

        public void username_password_empty(string Email_ID,string Password)
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            IWebElement SignINButton = driver.FindElement(By.XPath("//*[contains(text(),'Sign')]"));
            SignINButton.Click();
            IWebElement Email_filed = driver.FindElement(By.Name("email"));
            Email_filed.SendKeys(Email_ID);
            IWebElement Password_filed = driver.FindElement(By.Name("password"));
            Password_filed.SendKeys(Password);
            IWebElement Login_Button = driver.FindElement(By.XPath("//*[contains(text(),'Login')]"));
            Login_Button.Click();
        }

        
    }

    
}
