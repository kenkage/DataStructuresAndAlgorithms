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
    public class SimpleLinkedListTail
    {
        // head indicates the start  of the node
        Node head = null;
        Node tail = null;

        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            // Step 1 :- FirstItem
            // head --> newItem 
            // tail --> new item
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                // Step 2 :- SecondItem
                // current tails next item is set
                // to newItem. The current tail
                // is set to newItem.
                tail.next = newItem;
                tail = newItem;
            }
            
        }
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            // Step 1 :- FirstItem
            // head --> newItem 
            // tail --> new item
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                newItem.next = head;
                head = newItem;
            }
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
