using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    internal class Node
    {
        internal int data; 
        internal Node next; 

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    internal class SingleLinkedList
    {
        internal Node head;

        // Insertion From Front Part
        //internal void InsertFront(int new_data)
        //{
        //    Node new_node = new Node(new_data); 
        //    new_node.next = head; 
        //    head = new_node; 
        //}

        // Insertion from Last Part
        internal void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data); // Create a new node
            if (head == null) // If the list is empty
            {
                head = new_node; // Set head to the new node
                return;
            }

            Node lastNode = GetLastNode(); // Find the last node
            lastNode.next = new_node; // Link the last node to the new node
        }
        internal Node GetLastNode()
        {
            Node temp = head; // Start from the head
            while (temp.next != null) // Traverse until the next is null
            {
                temp = temp.next;
            }
            return temp; // Return the last node
        }

        internal void Display()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            Node current = head;
            
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            
        }
    }
}
