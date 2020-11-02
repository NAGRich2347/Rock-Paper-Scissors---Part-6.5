using System;

namespace Rock__Paper__Scissors___Part_6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            string rock;

            int num2;
            string paper;

            int num3;
            string scissors;

            int user_choice;



            bool keepPlaying = true;
            while (keepPlaying)
            {
                //Game Logic
                Console.WriteLine("Would you like to start a new game? <Y or N>");
                ConsoleKeyInfo cki = Console.ReadKey().ToUpper();
                keepPlaying = cki.KeyChar == 'y, Y';

                //Reads User Input
                Console.WriteLine("Please enter 1 for rock, 2 for paper, or 3 for scissors.");
                user_choice = Convert.ToInt32(Console.ReadLine());

                //Calculates Random Computer Selection
                Random ComputerChoice = new Random();
                int genRand = ComputerChoice.Next(1, 4);

                return ComputerChoice;

                }
            }
            ;
        }
    }
}
