using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharp.Helper;

namespace SeleniumCSharp.Examples.Set
{
    public class Dropdown
    {
        public static void StartUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/drop-down-menu-test/");

            IWebElement dropdown = driver.FindElement(By.Name("DropDownTest"));
            IWebElement option = driver.FindElement(By.CssSelector("#post-6 > div > p:nth-child(6) > select > option:nth-child(3)"));
            Thread.Sleep(2000);
            option.Click();
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
