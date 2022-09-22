using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_122_Review_Lecture_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Types
            // string - characters
            // whole numbers - int 
            // floating point - decimal, double, float
            // bool - true or false

            // To create an array
            string[] names = new string[10];
            // add something to an array
            // indexs start at 0
            // use the index to access an individual element in an array
            names[0] = "Will";
            Console.WriteLine(names[0]);
            string firstName = names[0];

            // To display to the screen
            //Console.WriteLine("This displays and goes to the next line");
            //Console.Write("This stays on the same line");

            // Reading a users input
            Console.Write("Enter your age: ");
            string userInput = Console.ReadLine();

            // String Literal - Place $ in front of your string to use {} for variables
            Console.WriteLine($"You are {userInput} years old");

            // You have to parse numbers ( tell the computer that they ARE numbers ) 
            //int age = int.Parse(userInput);
            //Console.WriteLine($"{age + age}");

            // TryParse(string, out number)
            int theNumber = 0;
            bool isANumber = int.TryParse(userInput, out theNumber);

            if (isANumber)
            {
                Console.WriteLine($"The number was {theNumber}");
            }
            else
            {
                Console.WriteLine($"That wasn't a number. {theNumber}");
            }

            // Condition 
            if (10 != 10)
            {
                Console.WriteLine("1");
            }
            else if (10 == 10)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }

            // switch

            switch ("5")
            {
                case "5":
                case "6":

                    Console.WriteLine("Does something");
                    break;
                default:
                    Console.WriteLine("Did nothing");
                    break;
            }

            // Loops
            // for
            // create a loop that starts at 5, goes to 10, increments by 2
            for (int i = 5; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }
            //for(;; )
            //{

            //}

            // for(start; finish; increment amount)
            // for(runs once, runs at the beggining, runs at the end)

            // while

            // Declaring and initializing variables
            string userName = Console.ReadLine();
            while (userName == "")
            {
                Console.WriteLine("Please enter a user name: ");
                userName = Console.ReadLine();
            }


            // do. while
            do
            {

            } while (userName == "");

            foreach (string name in names)
            {

            }

            // Operators
            // Math Operators + , -, /, *, %
            // % = modulus or mod
            // string + string does concatination
            // Assignment operators =, +=, -=, /=/ *=, %=
            // a = a + b
            // a += b;
            // bool operators >, <, >=, <=, ==, != 
            // always resolve to true or false
            // logical operators &&, ||, !
            // && - true && true
            // || - true || false
            // ! - !false

            int[] numbers = { 1, 2, 3, 4, 5, 3 };
            double average = Average(numbers);
            Console.WriteLine($"The average of your array is {average}");

        } // Main

        public static double Average(int[] numbers)
        {
            double total = (double)0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            // Make sure to cast when changes values from int to double
            return total / numbers.Length;
        } // Average()

    } // class

}// namespace
