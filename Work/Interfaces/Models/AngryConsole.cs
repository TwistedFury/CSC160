using Interfaces.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public class AngryConsole : IFunConsole
    {
        public void PrintInput(string input)
        {
            Console.WriteLine(input.ToUpper());
        }

        public string PromptForInput()
        {
            // Prompt provided by ChatGPT
            return CSC160_ConsoleMenu.CIO.PromptForInput("Enter your input. Or don’t. I’m just a program. What do I care?", false);

        }
    }
}
