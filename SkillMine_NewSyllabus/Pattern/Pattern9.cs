using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Pattern
{
    class Pattern9
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number of rows?");
                int row = int.Parse(Console.ReadLine());

                for (int i = 1; i <= row; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j == 2 || j == 4)
                            Console.Write("0 ");
                        else
                            Console.Write("* ");

                    }
                    Console.WriteLine();
                }
            }
        }
        class Zobin
        {
            static void Main(string[] args)
            {
                String input = Console.ReadLine();
                /* int a = Convert.ToInt32(input);
                 int b = Convert.ToInt32(input);
                 int c = Convert.ToInt32(input);
                 Console.WriteLine("a=" + a);
                 Console.WriteLine("b=" + b);
                 Console.WriteLine("c=" + c);*/
                int a = int.Parse(input);
                int b = int.Parse(input);
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("a=" + a);
                Console.WriteLine("b=" + b);
                Console.WriteLine("c=" + c);
            }
        }
    }
