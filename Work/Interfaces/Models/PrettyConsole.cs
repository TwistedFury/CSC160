using Interfaces.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public class PrettyConsole : IFunConsole
    {
        public void PrintInput(string input)
        {
            Console.BackgroundColor = ConsoleColor.Magenta; // Pink does not exist
            Console.WriteLine(input);
            Console.BackgroundColor = ConsoleColor.Black; // Resetting to not affect others
        }

        public string PromptForInput()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            string returnStr = CSC160_ConsoleMenu.CIO.PromptForInput("Tell me I'm pretty!", false); 
            Console.BackgroundColor = ConsoleColor.Black; // Resetting to not affect others
            return returnStr;
        }
    }
}
