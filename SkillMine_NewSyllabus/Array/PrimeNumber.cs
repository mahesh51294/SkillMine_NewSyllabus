using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus.Array
{
    class PrimeNumber
    {

        public void FindPrime(int[] a)
        {
            Console.WriteLine("Prime numbers From array is....");
            for (int i = 0; i < a.Length; i++)
            {
                bool flag = true;
                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0)
                    {
                        flag = false;

                    }
                }
                if (flag == true)
                {
                    Console.Write(a[i] + " ");
                }
            }


        }
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("Enter the Integer Element of array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            PrimeNumber p = new PrimeNumber();
            p.FindPrime(arr);





        }
    }
}
