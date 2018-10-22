﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class Program
    {
        public class TallGuy
        {
            public string Name;
            public int Height;

            public void TalkAboutYourself()
            {
                Console.WriteLine($"My name is {Name} and I'm {Height} inches tall");
            }
        }
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 74, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
        }
    }
}
