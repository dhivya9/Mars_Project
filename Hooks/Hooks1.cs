using BoDi;
using Marsproject.Support;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Marsproject.Hooks
{
    [Binding]
    public  class Hooks1
    {
        public readonly IObjectContainer _Container;
        

        public Hooks1(IObjectContainer container)
        {
            _Container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            IWebElement SignIn = driver.FindElement(By.XPath("//*[contains(text(),\"Sign\")]"));
            SignIn.Click();
            IWebElement Email = driver.FindElement(By.Name("email"));
            Email.SendKeys("dhivyaglitz23@gmail.com");
            IWebElement Password=driver.FindElement(By.Name("password"));
            Password.SendKeys("Dhivya@23");
            IWebElement signinbutton = driver.FindElement(By.XPath("//*[contains(text(),'Login')]"));
            signinbutton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            _Container.RegisterInstanceAs<IWebDriver>(driver);


        }
       
       

          
    
    [AfterScenario]
        public void AfterFeature()
        {
            var driver = _Container.Resolve<IWebDriver>();
            driver.Quit();
        }
        
        
    }
}