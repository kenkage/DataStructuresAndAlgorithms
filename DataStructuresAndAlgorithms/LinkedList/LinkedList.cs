using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinkedList
{
    
    // This class will have the logic
    // to connect the node objects to create
    // link list structure
    public class SimpleLinkedList
    {
        // head indicates the start  of the node
        Node head = null;
        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;

            if (head == null)
            {
                head = newItem;
                head.next = null;
            }
            else
            {
                Node current = head;
                // loop and find the last node
                while (current.next != null)
                {
                    current = current.next;
                }
                // exited as its NULL
                // and also this is the last element
                current.next = newItem;
                newItem.next = null;
            }
           
            
            
        }
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            // this is the first item
            // so the head becomes the next item of
            // the new item
            newItem.next = head;
            // newItem becomes the head
            head = newItem;
        }
        public void ReadAll()
        {
            Node current = head;
            // Loop until the last node
            // Last node is found until the 
            // next item of the node is not null
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);

        }
    }
}
