using ScratchConsole.Utilities;

namespace ScratchConsole.Weeks
{
    public class Week06
    {
        public static void Run()
        {
            DemoExtensionMethods();
        }

        public static void DemoExtensionMethods()
        {
            // Extension methods allow developers to add new methods to the public
            // contract of an existing CLR type, without having to sub-class it or
            // recompile the original type.

            // Extension Methods help blend the flexibility of "duck typing" support
            // popular within dynamic languages today with the performance and compile-time
            // validation of strongly-typed languages.
            // From https://stackoverflow.com/questions/403539/what-are-extension-methods

            int max = 10;
            int rand_num = max.GetRandom(1); // int rand_num = MyExtensions.GetRandom(max, 1);
        }

        /// <summary>
        /// Starts at 0 and counts to 100 printing each num to console
        /// Output should be all integers between 1 and 100 (inclusive)
        /// </summary>
        public static void RunRace01()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// In reverse, print each character of the input string on its own line
        /// </summary>
        public static void RunRace02(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }

        /// <summary>
        /// Get a random int between 17 and 38 (inclusive)
        /// Print to the console
        /// </summary>
        public static void RunRace03()
        {
            Console.WriteLine(38.GetRandom(17));
        }

    }
}
