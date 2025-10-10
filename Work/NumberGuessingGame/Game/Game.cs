using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Game
{
    internal class Game
    {
        private static int Attempts { get; set; }
        private static Difficulty Diff { get; set; }
        private static int Number { get; set; }
        private static int[] GuessedNumbers = new int[5];
        private static int GN_Count = 0;

        private enum Difficulty
        {
            Easy,
            Medium,
            Hard
        }

        public static void Run()
        {
            GameLoop();
        }

        private static void GetDifficultyFromUser()
        {
            bool accepted = false;
            int diffI = 0;
            Console.WriteLine("Easy: 1\nMedium: 2\nHard: 3");
            while (!accepted)
            {
                Console.Write("Difficulty: ");
                string? diff;
                diff = Console.ReadLine();
                if (!int.TryParse(diff, out diffI)) continue;
                if (diffI < 1 || diffI > 3) continue;
                Console.Write($"Difficulty Chosen: {diff}\nAccept? Y/N ");
                if (Console.ReadLine() == "Y") accepted = true;
            }
            switch (diffI)
            {
                case 1: Diff = Difficulty.Easy; break;
                case 2: Diff = Difficulty.Medium; break;
                case 3: Diff = Difficulty.Hard; break;
            }
        }

        private static void GameLoop()
        {
            GetDifficultyFromUser();
            Attempts = 5;
            GN_Count = 0;
            GuessedNumbers = new int[5];
            Random random = new Random();
            switch (Diff)
            {
                case Difficulty.Easy:
                    Number = random.Next(10) + 1;
                    break;
                case Difficulty.Medium:
                    Number = random.Next(50) + 1;
                    break;
                case Difficulty.Hard:
                    Number = random.Next(100) + 1;
                    break;
            }
            while (Attempts != 0)
            {
                Console.Write("Enter Guess: ");
                if (!int.TryParse(Console.ReadLine(), out int guess)) continue;
                if (GuessedNumbers.Contains(guess)) continue;
                if (guess <= 0) continue;
                GuessedNumbers[GN_Count++] = guess;
                if (guess == Number) break; // WIN
                if (guess < Number) Console.WriteLine($"{guess} was too low");
                else Console.WriteLine($"{guess} was too high");
                for (int i = 0; i < GuessedNumbers.Length; i++)
                {
                    if (GuessedNumbers[i] == 0) break;
                    if (i + 2 > 5 || GuessedNumbers[i + 1] == 0) Console.WriteLine(GuessedNumbers[i]);
                    else Console.Write($"{GuessedNumbers[i]}, ");
                }
                Console.WriteLine($"Attempts: {--Attempts}");
            }
            if (GuessedNumbers.Contains(Number)) Console.WriteLine($"YOU WIN");
            else Console.WriteLine($"YOU LOSE, NUMBER WAS {Number}");
            if (PlayAgain()) GameLoop();
        }

        private static bool PlayAgain()
        {
            Console.Write("Play Again? Y/N ");
            return Console.ReadLine() == "Y";
        }

    }
}
