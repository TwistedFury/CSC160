using ScratchConsole.Utilities;

namespace ScratchConsole.Weeks
{
    public class Week06
    {
        public static void Run()
        {
            RunRace03();
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
