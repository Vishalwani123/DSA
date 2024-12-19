using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Node2
    {
        internal int data;
        internal Node next;

        
        public Node2(int d)
        {
            data = d;
            next = null;
        }
    }
    internal class LinkedListQueue
    {
        private Node front; 
        private Node rear; 

        public LinkedListQueue()
        {
            this.front = this.rear = null; 
        }

        
        internal void Enqueue(int item)
        {
            Node newNode = new Node(item); 

            
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                
                this.rear.next = newNode;
                this.rear = newNode;
            }

            Console.WriteLine("{0} inserted into Queue", item);
        }

        
        internal void Dequeue()
        {
            
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            
            Node temp = this.front;
            this.front = this.front.next;

            
            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }

        
        internal void Display()
        {
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty.");
                return;
            }

            Node current = this.front;
            Console.WriteLine("Queue contents:");
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }

}
