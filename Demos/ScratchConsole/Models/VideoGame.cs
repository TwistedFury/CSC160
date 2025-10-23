using ScratchConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Models
{
    public class VideoGame : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("You're playing a GAME?!?!? Don't you have homework!?");
        }

        public void Stop()
        {
            Console.WriteLine("GOOD, NOW DO YOUR HOMEWORK!");
        }
    }
}
