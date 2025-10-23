namespace ConsoleIOApp
{
    using System.Security.Cryptography;
    using CSC160_ConsoleMenu;

    public class Program
    {
        private static void Main(string[] args)
        {
            TestPromptForMenuSelection(); // Put Test Method here
        }

        // Put Test Methods below here
        private static void TestPromptForMenuSelection()
        {
            List<string> options = new List<string>
            {
                "Play Game", 
                "Options",
                "Load Save"
            };
            CIO.PromptForMenuSelection(options, true);
        }

        private static void TestPromptForBool()
        {
            CIO.PromptForBool("Yes or No?", "yes", "no");
        }

        private static void TestPromptForByte()
        {
            // ranges from 0 to 255.
            CIO.PromptForByte("Enter a number from 1 - 9", 1, 9);
        }

        private static void TestPromptForShort()
        {
            // ranges from -32,768 to 32,767.
            CIO.PromptForShort("Enter a number from 300 - 10,000", 300, 10000);
        }

        private static void TestPromptForInt()
        {
            // ranges from -2,147,483,648 to 2,147,483,647.
            CIO.PromptForInt("Enter a number from -1,000,000 - 100,000,000", -1000000, 100000000);
        }

        private static void TestPromptForLong()
        {
            // ranges from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            CIO.PromptForLong("Enter a number from -3,000,000,000 - 3,000,000,000", -3000000000, 3000000000);
        }

        private static void TestPromptForFloat()
        {
            // ranges from ±1.5 x 10^-45 to ±3.4 x 10^38 (6-9 point precision)
            CIO.PromptForFloat("Enter a floating point number from -5.6 - 100,000", -5.6f, 100000);
        }

        private static void TestPromptForDouble()
        {
            // ranges from ±5.0 × 10^−324 to ±1.7 × 10^308 (15-17 point precision)
            CIO.PromptForDouble("Enter a number from -100,000,000,000.75 - 19,010,234.4112", 100000000000.75, 19010234.4112f);
        }

        private static void TestPromptForDecimal()
        {
            // ranges from ±1.0 x 10^-28 to ±7.9228 x 10^28 (28-29 point precision)
            CIO.PromptForDecimal("Enter a number from -81,927,190,293.57820 - 210,234,791.43291338", (decimal)-81927190293.57820, (decimal)210234791.43291338);
        }

        private static void TestPromptForInput()
        {
            CIO.PromptForInput("What's your favorite color?", false);
        }
        private static void TestPromptForChar()
        {
            // Looked up a table of all UTF-16 codes; ! to ~ excludes CTRL-(anything) and Space
            CIO.PromptForChar("Enter a char (e.g. a b . / ? } [ 0 + %)", '!', '~');
        }

    }
}