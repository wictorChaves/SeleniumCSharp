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
    public class RadioButton
    {
        public static void StartUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://testing.todvachev.com/special-elements/radio-button-test/");

            string[] options = { "1", "3", "5" };

            for (int i = 0; i < options.Length; i++)
            {
                IWebElement radio = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=radio]:nth-child(" + options[i] + ")"));

                Console.WriteLine("Checkbox " + (i + 1));
                Console.WriteLine("Checked: " + (radio.GetAttribute("checked") == "true" ? "true" : "false"));
                Console.WriteLine("Value: " + radio.GetAttribute("value"));
                Console.WriteLine("");
            }

            driver.Quit();
        }
    }
}
