using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatornew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompting the user to enter the first number collecting their result in the var number
            Console.Write("Enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            //prompting user to enter any operator from +, -, /, * and storing the result in op
            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            //prompting user to enter the second number used to calculate 
            Console.Write("Enter another number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            //if statement using recorded operator will either add, subtract, divide, or multiply depending on numbers user entered
            if (op == "+")
            {
                Console.WriteLine(number + number2);
                Console.ReadLine();
            }
            else if (op == "-")
            {
                Console.WriteLine(number - number2);
                Console.ReadLine();

            }
            else if (op == "/")
            {
                Console.WriteLine(number / number2);
                Console.ReadLine();

            }
            else if (op == "*")
            {
                Console.WriteLine(number * number2);
                Console.ReadLine();

                //else statement incase user enters a wrong operator this will give them another try to caculate
            }
            else
            {
                //using same variable concept with different names numberAgain, opAgain, and number2Again
                Console.WriteLine("Invalid operator entry, Try again please! ");            

                Console.Write("Enter a number: ");
                double numberAgain = Convert.ToDouble(Console.ReadLine());
                

                Console.Write("Enter Operator: ");
                string opAgain = Console.ReadLine();

                Console.Write("Enter another number: ");
                double number2Again = Convert.ToDouble(Console.ReadLine());

                //same if statement with the changed variable names for second try of calculation
                if (opAgain == "+")
                {
                    Console.WriteLine(numberAgain + number2Again);
                    Console.ReadLine();

                }
                else if (opAgain == "-")
                {
                    Console.WriteLine(numberAgain - number2Again);
                    Console.ReadLine();
                }
                else if (opAgain == "/")
                {
                    Console.WriteLine(numberAgain / number2Again);
                    Console.ReadLine();
                }
                else if (opAgain == "*")
                {
                    Console.WriteLine(numberAgain * number2Again);
                    Console.ReadLine();
                }
                

            }
        }
    }
}

