using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp.Helper
{
    public class Message
    {
        public static void Green(string message)
        {
            Message.Color(message, ConsoleColor.Green);
        }

        public static void Red(string message)
        {
            Message.Color(message, ConsoleColor.Red);
        }

        public static void DarkCyan(string message)
        {
            Message.Color(message, ConsoleColor.DarkCyan);
        }

        public static void Color(string message, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
