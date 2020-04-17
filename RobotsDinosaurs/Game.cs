using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Game
    {
        string userInput;
        bool validInput;
        Fleet fleet;
        Herd herd;

        public Game()
        {
            fleet = new Fleet();
            herd = new Herd();
        }

        public void PressEnterToContinue()
        {
            Console.WriteLine("Press [ENTER] to continue.");
            Console.ReadLine();
        }

        public void Introduction()
        {
            Console.WriteLine("Welcome to Robosaurs – a simple console game where robots fight dinosaurs!");
            PressEnterToContinue();
        }

        public void GameMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an option by entering the corresponding number!\n\n" +
                    "1.) Play\n" +
                    "2.) Rules\n" +
                    "3.) Exit");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("1");
                        Play();
                        break;
                    case "2":
                        DisplayRules();
                        break;
                    case "3":
                        ExitGame();
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice.");
                        PressEnterToContinue();
                        break;
                }

            }

        }

        public void Play()
        {
            validInput = false;
            while (validInput == false)
            {
                Console.Clear();
                Console.WriteLine("Choose your team by entering the corresponding number!\n\n" +
                    "1.) Robots\n" +
                    "2.) Dinosaurs");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Your team: robots!");
                        PressEnterToContinue();
                        validInput = true;
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Your team: dinosaurs!");
                        PressEnterToContinue();
                        validInput = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice.");
                        PressEnterToContinue();
                        break;
                }


            }

        }

        public void DisplayRules()
        {

        }

        public void ExitGame()
        {
            Environment.Exit(0);
        }

        public void Initialize()
        {
            Introduction();
            GameMenu();
        }
    }
}
