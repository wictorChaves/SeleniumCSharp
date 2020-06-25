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
    public class Checkbox
    {
        public static void StartUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/check-button-test-3/");
            IWebElement checkbox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(1)"));
            Thread.Sleep(1000);
            checkbox.Click();
            Thread.Sleep(3000);    
            driver.Quit();
        }
    }
}
