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

            // Fizz Buzz math for even or odd
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            int retirement = age % 2;

            if (age == 0)
            {
                Console.WriteLine("12 years");
            }
            else
            {
                Console.WriteLine("14 years");
            }
            
            
            Console.WriteLine("What is the number of your birth month?");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            //if statement for birth month

            if (birthMonth >= 0 && birthMonth <= 5)
            {
                Console.WriteLine("$256,000.76");
            }
            else if (birthMonth >= 5 && birthMonth <= 9)
            
            {
                Console.WriteLine("$3,687,105.42");
            }
            else if (birthMonth >= 9 && birthMonth <= 13)
            
            {
                Console.WriteLine("$86.23");
            }
            else
            {
                Console.WriteLine("0.00");
            }
                            
            Console.WriteLine("Which is your favorite Color?");
            Console.WriteLine("Enter the word Help to get a list of ROYGBIV");
            string roygbiv = Console.ReadLine();

            if (roygbiv.Equals("Help"))
            {
                Console.WriteLine(" The ROYGBIV colors are red, orange, yellow, green, blue, indigo, violet.");
                Console.WriteLine("Which is your favorite Color?");
                roygbiv = Console.ReadLine();
            }

            ///Do switch statement for colors to cars  colors should be in quotes

            switch (roygbiv)
            {
                case "red":
                    Console.WriteLine("48 inch deck Kubota");
                    break;
                case "orange":
                    Console.WriteLine("Amphibus");
                    break;
                case "yellow":
                    Console.WriteLine("treadmill bike");
                    break;
                case "green":
                    Console.WriteLine("forklift");
                    break;
                case "blue":
                    Console.WriteLine("jetpack");
                    break;
                case "indigo":
                    Console.WriteLine("hovercraft");
                    break;
                case "violet":
                    Console.WriteLine("dog sled");
                    break;
            }

            Console.WriteLine("How many siblings do you have?");
            int numberOfSiblings = Convert.ToInt32(Console.ReadLine());

            //switch statement or if statement for town

            if (numberOfSiblings.Equals("0"))
            {
                Console.WriteLine("China");
            }
            else if (numberOfSiblings.Equals("1"))
            {
                Console.WriteLine("Ashtabula, Ohio");
            }
            else if (numberOfSiblings.Equals("2"))
            {
                Console.WriteLine("Chicken Alaska");
            }
            else if (numberOfSiblings.Equals("3"))
            {
                Console.WriteLine("Big Arm, Montana");
            }
            else if (numberOfSiblings.Equals("4"))
            {
                Console.WriteLine("Bugtussle, Kentucky");
            }
            else
            {
                Console.WriteLine("Burnt Porcupine, Maine");
            }

            string str = firstName + lastName + " will retire in" + retirement + " years with" + birthMonth + " in the bank, " + " a vacation home in" + numberOfSiblings + " and travel by" + roygbiv.";

            System.Console.WriteLine(str);












        }
    }
}
