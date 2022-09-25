using Calculator.DAL;
using System;

namespace Calculator
{
    class Calc
    {
        static void Main()
        {
            bool isExit = false;

            while (!isExit)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter your choice. 1-Add, 2-Sub, 3-Mul, 4-Division, 5-Exit");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int firstNumber = 0, secondNumber = 0;
                if (userInput >= 1 && userInput<=4 )
                {
                    Console.WriteLine("Please enter your first number");
                    firstNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter your second number");
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                }
                

                string result = String.Empty;

                if (userInput == 1)
                {
                    result = "Sum of " + firstNumber + " + " + secondNumber + " = " + CalculatorDAL.Sum(firstNumber, secondNumber);
                }
                else if (userInput == 2)
                {
                    result = "Substract of " + firstNumber + " - " + secondNumber + " = " + CalculatorDAL.Subtraction(firstNumber, secondNumber);
                }
                else if (userInput == 3)
                {
                    result = "Multiply of " + firstNumber + " * " + secondNumber + " = " + CalculatorDAL.Multiplication(firstNumber, secondNumber);
                }
                else if (userInput == 4)
                {
                    result = "Division of " + firstNumber + " / " + secondNumber + " = " + CalculatorDAL.Division(firstNumber, secondNumber);
                }
                else if (userInput == 5)
                {
                    isExit = true;
                    Console.WriteLine("Thank you for visiting");
                }
                else 
                {
                    Console.WriteLine("Wrong input.Try again");
                }
                Console.WriteLine(result);
            }                       
        }
    }
}