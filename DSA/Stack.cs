using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Node1
    {
        internal int data; // Value of the node
        internal Node next; // Reference to the next node

        // Constructor to initialize node with data
        public Node1(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class LinkListStack
    {
        Node top; 

        
        public LinkListStack()
        {
            this.top = null;
        }

        
        internal void Push(int value)
        {
            Node newNode = new Node(value); 

            if (top == null) 
            {
                newNode.next = null; 
            }
            else
            {
                newNode.next = top; 
            }

            top = newNode; 
            Console.WriteLine("{0} pushed to stack", value);
        }
        internal int Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow. Cannot pop from an empty stack.");
                return -1; // Return -1 or throw an exception to indicate underflow
            }

            int poppedValue = top.data; // Get the data of the top node
            top = top.next; // Update top to the next node
            Console.WriteLine("{0} popped from stack", poppedValue);
            return poppedValue;
        }
        internal void Peek()
        {
            if (top == null) 
            {
                Console.WriteLine("Stack Underflow.");
                return;
            }

            Console.WriteLine("{0} is on the top of the stack", this.top.data);
        }

        internal void Display()
        {
            if (top == null)
            {
                Console.WriteLine("The stack is empty.");
                return;
            }

            Node current = top;
            Console.WriteLine("Stack contents:");
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }

}
