using ScratchConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Models
{
    public class Movie : IComparable<Movie>, IPlayable
    {
        // CREATE PROPERTIES
        // Full Property (propfull)
        private string title = "SHULL";

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        // Automatic Property (prop)
        public int Year { get; set; }

        public int CompareTo(Movie? other)
        {
            Movie m2 = other!;

            // Title Alphabetical THEN Year Reverse Chronologically
            int result = this.Title.ToLower().CompareTo(m2.Title.ToLower());
            if (result == 0) { result = m2.Year - this.Year; }
            
            return result;
        }

        public void Play()
        {
            Console.WriteLine($"The movie {Title} is playing...");
        }

        public void Stop()
        {
            Console.WriteLine($"The movie {Title} has stopped.");
        }

        public override string ToString()
        {
            // String Interpolation
            return $"{Title} ({Year})";
        }
    }
}
