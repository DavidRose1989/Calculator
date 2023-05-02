using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = double.Parse(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write(num1 - num2);
            }
            else if (op == "/") 
            {
                Console.WriteLine(num1 / num2);
            }
            else if(op == "*")
            {
                Console.WriteLine( num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();
        }




    }




}