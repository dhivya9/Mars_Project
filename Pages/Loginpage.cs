using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsproject.Pages
{
    public class Loginpage
    {

        public By SignInButton = By.XPath("//*[contains(text(),'Sign')]");

        public By Email_field = By.Name("email");

        public By Password_field = By.Name("password");

        public By Loginbutton = By.XPath("//*[contains(text(),'Login')]");

        public By homepage_text = By.XPath("//*[contains(text(),'Mars Logo')]");

        public By EmailID_field = By.Name("email");

       
        public void Loginwith_INvalid_cerdentials(IWebDriver driver, string Email_ID, string Password)
        {
           
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            driver.FindElement(SignInButton).Click();
            driver.FindElement(Email_field).SendKeys(Email_ID);
            driver.FindElement(Password_field).SendKeys(Password);
            driver.FindElement(Loginbutton).Click();
            

            if (driver.FindElement(EmailID_field).GetAttribute("email") != "dhivyaglitz23@gmail.com")
            {
                Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
                screenshot.SaveAsFile("C:\\Mars\\Marsproject\\Screenshot\\Image1 " + System.Drawing.Imaging.ImageFormat.Png);
                Console.WriteLine("Invalid E-MailID,Pls refer Screenshot");

            }
           

  
           
        }

    }
}
