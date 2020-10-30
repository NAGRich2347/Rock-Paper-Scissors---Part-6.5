using System;

namespace Rock__Paper__Scissors___Part_6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int rock = 1;
            int paper = 2;
            int scissors = 3;
            round_num = 0;
            int user_choice = 0;

            Random r = new Random();
            int genRand = r.Next();
            
            Console.WriteLine("Welcome, to Rock, Paper, Scissors!");
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("How many rounds would you like to play?");
            round_num = Convert.ToInt32(Console.ReadLine());
            
            

            Console.WriteLine("Please enter 1 for rock, 2 for paper, or 3 for scissors.");
            
            user_choice = Convert.ToInt32(Console.ReadLine());
            ;
        }
    }
}
