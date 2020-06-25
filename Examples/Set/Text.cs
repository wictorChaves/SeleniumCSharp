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
    public class Text
    {
        public static void StartUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/text-input-field/");
            IWebElement element = driver.FindElement(By.Name("username"));
            element.SendKeys("Test text");
            Thread.Sleep(3000);
            element.Clear();
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
