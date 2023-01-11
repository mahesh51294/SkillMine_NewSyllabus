using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SkillMine_NewSyllabus
{
    class Simple
    {
        public void m1()
        {
            lock (this)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(2000);
                }
            }
        }
        public void m2()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }

    public class Program1
    {
        static void Main(string[] args)
        {
            Simple obj = new Simple();
            Thread t1 = new Thread(new ThreadStart(obj.m1));
            Thread t2 = new Thread(new ThreadStart(obj.m2));


            t1.Start();
            t2.Start();

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;


        }
    }

}
