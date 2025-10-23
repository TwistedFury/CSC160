using Interfaces.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public class PirateConsole : IFunConsole
    {
        public void PrintInput(string input)
        {
            string toPrint = "";
            foreach (char c in input)
            {
                if (c == 'r') toPrint += "-ARR-";
                else toPrint += c;
            }
            Console.WriteLine(toPrint + ", me hearty!");
        }

        public string PromptForInput()
        {
            return CSC160_ConsoleMenu.CIO.PromptForInput("Arrr me matey! Enter ye here some worthwhile news and I'll share with ye me rum!", false);
        }
    }
}
