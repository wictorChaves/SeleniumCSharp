using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharp.Examples;
using System.Threading;
using System;
using SeleniumCSharp.Helper;
using SeleniumCSharp.Examples.ElementSelectors;
using SeleniumCSharp.Examples.SpecialElements;
using SeleniumCSharp.CTN.Filiacao;
using SeleniumCSharp.CTN.Helper;

namespace SeleniumCSharp
{
    class EntryPoint
    {
        static void Main()
        {
            FiliacaoMain filiacaoMain = new FiliacaoMain();
            filiacaoMain.StartUp();
            Console.ReadKey();
        }
    }
}
