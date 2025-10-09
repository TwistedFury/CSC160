using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Models
{
    public class Movie
    {
        // CREATE PROPERTIES
        // Full Property (propfull)
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        // Automatic Property (prop)
        public int Year { get; set; }



        public override string ToString()
        {
            // String Interpolation
            return $"{Title} ({Year})";
        }
    }
}
