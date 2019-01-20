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

            int evenOrOdd = age % 2;
            string retirement;
            if (evenOrOdd == 0)
            {
                retirement = "12 years";
            }
            else
            {
                retirement = "14 years";
            }


            Console.WriteLine("What is the number of your birth month?");
            int birthMonth = Convert.ToInt32(Console.ReadLine());
            string moneyInBank;            

            //if statement for birth month

            if (birthMonth >= 0 && birthMonth <= 5)
            {
                moneyInBank = "$256,000.76";
            }
            else if (birthMonth >= 5 && birthMonth <= 9)

            {
                moneyInBank = "$3,687,105.42";
            }
            else if (birthMonth >= 9 && birthMonth <= 13)

            {
                moneyInBank = "$86.23";
            }
            else
            {
                moneyInBank = "0.00";
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

            string modeOfTransportation;


            ///Do switch statement for colors to cars,  cars should be in quotes

            switch (roygbiv)
            {
                case "red":
                    modeOfTransportation = "48 inch deck Kubota";
                    break;
                case "orange":
                    modeOfTransportation = "Amphibus";
                    break;
                case "yellow":
                    modeOfTransportation = "treadmill bike";
                    break;
                case "green":
                    modeOfTransportation = "forklift";
                    break;
                case "blue":
                    modeOfTransportation = "jetpack";
                    break;
                case "indigo":
                    modeOfTransportation = "hovercraft";
                    break;
                case "violet":
                    modeOfTransportation = "dog sled";
                    break;
            }

            Console.WriteLine("How many siblings do you have?");
            int numberOfSiblings = Convert.ToInt32(Console.ReadLine());

            string vacationHome;

            //switch statement or if statement for town

            if (numberOfSiblings.Equals("0"))
            {
                vacationHome = "China";
            }
            else if (numberOfSiblings.Equals("1"))
            {
                vacationHome = "Ashtabula, Ohio";
            }
            else if (numberOfSiblings.Equals("2"))
            {
                vacationHome = "Chicken, Alaska";
            }
            else if (numberOfSiblings.Equals("3"))
            {
                vacationHome = "Big Arm, Montana";
            }
            else if (numberOfSiblings.Equals("4"))
            {
                vacationHome = "Bugtussle, Kentucky";
            }
            else
            {
                vacationHome = "Burnt Porcupine, Maine";
            }

            string str = firstName + lastName + " will retire in " + retirement + " years with " + moneyInBank + " in the bank, " + " a vacation home in " + vacationHome + " and travel by" + modeOfTransportation + ".";

            Console.WriteLine(str);

        }
    }
}
