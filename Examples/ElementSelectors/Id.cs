using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharp.Helper;

namespace SeleniumCSharp.Examples.ElementSelectors
{
    class Id
    {
        public static void StartUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/id/");
            IWebElement element = driver.FindElement(By.Id("testImage"));
            if (element.Displayed)
            {
                Message.Green("Yes! I can see the element, it´s right there!!!");
            }
            else
            {
                Message.Red("Well, something went wrong, I couldn't see the element!");
            }
            driver.Quit();
        }
    }
}
