using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharp.Helper;

namespace SeleniumCSharp.Examples.SpecialElements
{
    public class Alert
    {
        public static void StartUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/alert-box/");
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(2000);
            alert.Accept();
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
