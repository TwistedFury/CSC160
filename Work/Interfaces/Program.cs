using Interfaces.Interface;
using Interfaces.Models;

namespace FunConsoleInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            IFunConsole funConsole = new PirateConsole();
            funConsole.PrintInput(funConsole.PromptForInput());
            funConsole = new PrettyConsole();
            funConsole.PrintInput(funConsole.PromptForInput());
            funConsole = new AngryConsole();
            funConsole.PrintInput(funConsole.PromptForInput());
        }
    }
}