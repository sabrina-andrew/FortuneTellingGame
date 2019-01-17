using System;

namespace FortuneTellerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("What is your birth month?");
            int birthMonth = Convert.ToInt32(Console.ReadLine());
                        
            Console.WriteLine("Which is your favorite Color?");
            Console.WriteLine("Enter the word Help to get a list of ROYGBIV");
            string roygbiv = Console.ReadLine();

            if (roygbiv.Equals("Help"))
            {
                Console.WriteLine(" The ROYGBIV colors are red, orange, yellow, green, blue, indigo, violet.");
                Console.WriteLine("Which is your favorite Color?");
                string roygbiv = Console.ReadLine()
            }

            // Fizz Buzz math for even or odd

            ///Do switch statement for colors to cars  colors should be in quotes

            //switch statement or if statement for town

            //if statement for birth month





        }
    }
}
