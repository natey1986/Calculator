using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Converting methold ouputs to variables
            float userFirstNumber = FirstNumber();
            string userOperation = MathOperation();
            float userSecondNumber = SecondNumber();

            //Creating variable for user answer
            float userAnswer;


            //Performs math operations for user inputs
            if (userOperation == "+")
                userAnswer = userFirstNumber + userSecondNumber;
            else if (userOperation == "-")
                userAnswer = userFirstNumber - userSecondNumber;
            else if (userOperation == "*")
                userAnswer = userFirstNumber * userSecondNumber;
            else if (userOperation == "/")
                userAnswer = userFirstNumber / userSecondNumber;
            else
                userAnswer = 999;

            //Printing answer
            Console.WriteLine(userFirstNumber + " " + userOperation + " " + userSecondNumber + " = " + userAnswer);

            Console.ReadLine();
        }
       
        // Method - Gets users first number
        static int FirstNumber()
        {
            int userFirstNumber;
            bool check;

            Console.WriteLine("Enter first number");
            
            //Ensures only a number is used
            do
            {
                check = int.TryParse(Console.ReadLine(), out userFirstNumber);

                if (!check)
                    Console.WriteLine("please enter a number");
                else
                    break;

            }
            while (!check);

            return (userFirstNumber);
        }

        //Method to get math operation
        static string MathOperation()
        {
            //Variables
            string userMathOperation;

            //Ask user for math operation input
            Console.WriteLine("enter one math operation: +, -, *, / ");

            //Assigns input to userMathOperation and checks that correct operation was used
            do
            {
                string userMathOperationInput = Console.ReadLine();

                if (userMathOperationInput == "+")
                    userMathOperation = userMathOperationInput;
                else if (userMathOperationInput == "-")
                    userMathOperation = userMathOperationInput;
                else if (userMathOperationInput == "*")
                    userMathOperation = userMathOperationInput;
                else if (userMathOperationInput == "/")
                    userMathOperation = userMathOperationInput;
                else
                {
                    Console.WriteLine("Please enter a correct math operation.");
                    userMathOperation = "none";
                }


            }
            while (userMathOperation == "none");

            return userMathOperation;
        }
       
        // Method - Gets users second number
        static int SecondNumber()
        {
            int userSecondNumber;
            bool check;

            Console.WriteLine("Enter Second number");

            //Ensures only a number is used
            do
            {
                check = int.TryParse(Console.ReadLine(), out userSecondNumber);

                if (!check)
                    Console.WriteLine("please enter a number");
                else
                    break;

            }
            while (!check);
            
            return (userSecondNumber);
        }
    }
}
