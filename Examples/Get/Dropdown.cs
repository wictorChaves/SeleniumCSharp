using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharp.Helper;

namespace SeleniumCSharp.Examples.Get
{
    public class Dropdown
    {
        public static void StartUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/drop-down-menu-test/");

            IWebElement dropdown = driver.FindElement(By.Name("DropDownTest"));

            Console.WriteLine("Current Value: " + dropdown.GetAttribute("value"));
            Console.WriteLine("");
            Console.WriteLine("Another values");
            Console.WriteLine("");

            for (int i = 1; i <= 4; i++)
            {
                IWebElement option = driver.FindElement(By.CssSelector("#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")"));
                Console.WriteLine("Option " + i + " value: " + option.GetAttribute("value"));
            }

            driver.Quit();
        }
    }
}
