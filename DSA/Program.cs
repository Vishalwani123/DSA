using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linked-List Concepts
            //SingleLinkedList singlyList = new SingleLinkedList();

            //Console.WriteLine();
            //Console.WriteLine("Enter the size upto you want to add data in LinkedList : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for(int i = 0; i < num; i++)
            //{
            //    int d1 = Convert.ToInt32(Console.ReadLine());
            //    singlyList.InsertLast(d1);
            //}

            //Console.WriteLine();

            //Console.WriteLine("LinkedList after insertion : ");
            //singlyList.Display();

            // Stack Concepts
            //LinkListStack stack = new LinkListStack();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //stack.Display();

            //stack.Peek();

            //stack.Pop();

            //stack.Display();

            //stack.Pop();
            //stack.Pop();
            //stack.Pop();

            // Queue Concepts
            LinkedListQueue queue = new LinkedListQueue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Display();

            queue.Dequeue();
            queue.Dequeue();

            queue.Display();

            queue.Dequeue();
            queue.Dequeue();
        }
    }
}
