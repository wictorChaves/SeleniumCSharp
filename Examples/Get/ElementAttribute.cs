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
    public class ElementAttribute
    {
        public static void StartUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/text-input-field/");
            IWebElement element = driver.FindElement(By.CssSelector(".entry-thumbnail > img"));
            Console.WriteLine(element.GetAttribute("src"));
            driver.Quit();
        }
    }
}
