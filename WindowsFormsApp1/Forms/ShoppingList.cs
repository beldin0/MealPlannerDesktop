using MealPlannerApp.Classes;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MealPlannerApp.Forms
{
    public partial class ShoppingList : Form
    {
        internal List<string> meals;
        internal Dictionary<string, int> ingredients;
        IWebDriver driver;
        public Form MyParent { get; set; }

        public ShoppingList()
        {
            InitializeComponent();
        }

        private void ShoppingList_Shown(object sender, EventArgs e)
        {
            lstMeals.DataSource = meals;
            lstIngredients.DataSource = ingredients.Keys.ToList<string>();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            FillShoppingList(list, ingredients.Keys);
            FileIOManager fm = new FileIOManager("every week.txt");
            FillShoppingList(list, fm.Read());
            using (LoginDetails login = LoginDetailsManager.GetLoginDetails())
            {
                if (login == null) return;
                DoShopping(login, list);
            }
        }

        private void DoShopping(LoginDetails login, List<string> shopping)
        {
            driver = getDriver();
            driver.Url = "https://secure.tesco.com/account/en-GB/login";
            IWebElement element = driver.FindElement(By.Id("username"));
            element.SendKeys(login.Username);
            element = driver.FindElement(By.Id("password"));
            element.SendKeys(login.Password);
            element.Submit();
            driver.FindElement(By.ClassName("search-bar"));
            driver.Url = "https://www.tesco.com/groceries/en-GB/multi-search";
            driver.FindElement(By.ClassName("multi-search-form__clear-list-button")).Click();
            for (int i=0; i<shopping.Count; i++)
            {
                element = driver.FindElement(By.Id("listItem" + i));
                element.SendKeys(shopping[i]);
                element = driver.FindElement(By.Id("listItem" + (i + 1)));
                element.Click();
            }
        }

        private void FillShoppingList(List<string> list, IEnumerable<string> items)
        {
            string line = "";
            foreach (string ingredient in items)
            {
                if (line.Length + ingredient.Length < 90)
                {
                    line += ingredient + ",";
                }
                else
                {
                    list.Add(line);
                    line = "";
                }
            }
            if (line != "") list.Add(line);
        }

        private IWebDriver getDriver()
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            IWebDriver d = new ChromeDriver(chromeDriverService, new ChromeOptions());
            d.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return d;
        }

        private void ShoppingList_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MyParent != null) MyParent.Show();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ShoppingList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall && DialogResult != DialogResult.OK)
            {
                e.Cancel = (ExtensionMethods.QuitDialog() == DialogResult.No);
                if (!e.Cancel) Application.Exit();
            }
        }
    }
}
