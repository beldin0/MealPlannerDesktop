using MealPlannerApp.Classes.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerApp.Classes
{
    class TescoShoppingManager : IShoppingManager
    {
        private string _username;
        private string _password;
        public string LoginUserName { set { _username = value; } }
        public string LoginPassword { set { _password = value; } }

        IWebDriver driver;

        public void DoShopping(List<string> shopping)
        {
            shopping.ConcatList(90);
            if (driver == null)
            {
                RegisterDriver();
            }
            driver.Url = "https://secure.tesco.com/account/en-GB/login";
            IWebElement element = driver.FindElement(By.Id("username"));
            element.SendKeys(_username);
            element = driver.FindElement(By.Id("password"));
            element.SendKeys(_password);
            element.Submit();
            driver.FindElement(By.ClassName("search-bar"));
            driver.Url = "https://www.tesco.com/groceries/en-GB/multi-search";
            driver.FindElement(By.ClassName("multi-search-form__clear-list-button")).Click();
            for (int i = 0; i < shopping.Count; i++)
            {
                element = driver.FindElement(By.Id("listItem" + i));
                element.SendKeys(shopping[i]);
                element = driver.FindElement(By.Id("listItem" + (i + 1)));
                element.Click();
            }
        }
        
        private void RegisterDriver()
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            driver = new ChromeDriver(chromeDriverService, new ChromeOptions());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void Deregister()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
