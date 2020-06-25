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
    public class Checkbox
    {
        public static void StartUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/check-button-test-3/");

            IWebElement checkbox1 = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(1)"));
            IWebElement checkbox2 = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(3)"));

            Console.WriteLine("Checkbox 1");
            Console.WriteLine("Checked: " + (checkbox1.GetAttribute("checked") == "true" ? "true" : "false"));
            Console.WriteLine("Value: " + checkbox1.GetAttribute("value"));
            Console.WriteLine("");

            Console.WriteLine("Checkbox 2");
            Console.WriteLine("Checked: " + (checkbox2.GetAttribute("checked") == "true" ? "true" : "false"));
            Console.WriteLine("Value: " + checkbox2.GetAttribute("value"));
            Console.WriteLine("");

            driver.Quit();
        }
    }
}
