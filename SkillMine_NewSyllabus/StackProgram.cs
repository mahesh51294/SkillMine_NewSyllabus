using System;
using System.Collections;
using System.Text;

namespace SkillMine_NewSyllabus
{
    class StackProgram
    {
        static void Main(string[]args)
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            s.Push(50);
            //s.Pop();
            s.Peek();

            foreach(var item in s)
            {
                Console.WriteLine(item);
            }


        }
    }

    class QueueProgram
    {
        static void Main(string[]args)
        {
            Queue q = new Queue();

            q.Enqueue(12);
            q.Enqueue(13);
            q.Enqueue(14);
            q.Enqueue(17);
            q.Enqueue(19);
            q.Dequeue();
            q.Enqueue(20);
           Console.WriteLine(q.Count);

            q.Peek();

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }

    

}
