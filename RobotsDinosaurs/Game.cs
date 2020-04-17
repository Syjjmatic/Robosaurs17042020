using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Game
    {
        public string input;

        public void PressEnterToContinue()
        {
            Console.WriteLine("Press [ENTER] to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        public void Introduction()
        {
            Console.WriteLine("Welcome to Robosaurs – a simple console game where robots fight dinosaurs!");
            PressEnterToContinue();
            Console.WriteLine("Choose your team!\n\n" +
                "1.) Robots\n" +
                "2.) Dinosaurs");
            input = Console.ReadLine();
        }

        public void Initialize()
        {
            Introduction();

        }
    }
}
