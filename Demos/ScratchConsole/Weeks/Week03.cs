using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchConsole.Interfaces;
using ScratchConsole.Models;

namespace ScratchConsole.Weeks
{
    public static class Week03
    {
        public static void Run()
        {
            DemoInterfaces();
        }

        public static void DemoInterfaces()
        {
            IPlayable[] playables =
            {
                new Movie { Title = "The Bee Movie", Year = 2007 },
                new VideoGame() // The Last of Hollow Knight Song of Silk Road to Catan for all dem Settler Hunters 2
            };

            foreach (IPlayable playable in playables)
            {
                playable.Play();
                playable.Stop();
                Console.WriteLine();
            }
        }

        public static void DemoIComparable()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie { Title = "Krull", Year = 1983 },
                new Movie { Title = "Croods 2", Year = 2023 },
                new Movie { Title = "The Matrix", Year = 1999 },
                new Movie { Title = "The Amazing Spider-Man 2", Year = 2012 },
                new Movie { Title = "Return of the King", Year = 2003 },
                new Movie { Title = "Halloween", Year = 1978 },
                new Movie { Title = "Halloween", Year = 2018 }
            };

            movies.Sort();
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }
        }

        public static void DemoForEachLoop()
        {
            //for (int num : nums) { }
            int[] nums = new int[10];
            foreach(int num in nums)
            {
                //  THINGS
            }
        }
    }
}
