using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.SwitchCase
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------Operation Menu----------------   ");
            Console.WriteLine("1. Addition\n2. Multiplication\n3. Divition\n4. Substraction");
            Console.WriteLine("Enter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addtion is: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Multiplication is: " + (a * b));
                    break;
                case 3:
                    Console.WriteLine("Divition is: " + (a / b));
                    break;
                case 4:
                    Console.WriteLine("Substraction is : " + (a - b));
                    break;
                default:
                    Console.WriteLine("No such choise is present please try again..");
                    break;
            }
        }
    }
}
