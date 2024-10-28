using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizer
{
    internal class SinglyLinkedList
    {
        public Node head;
        public SinglyLinkedList()
        {
            head = null;
        }
        public void insertLast(string name, string category)
        {
            Node newNode = new Node(name, category);
            if (head == null)
                head = newNode;
            else
            {
                Node temp = head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = newNode;
            }
        }        

        public void removeNode(string name) // Removes the node with the studentName as given name in the parameter
        {
            Node pointer = head;
            Node prevPointer = head;
            if (head == null)
                Console.WriteLine("Student doesnt exists");
            else
            {
                while (pointer.studentName != name)
                {
                    prevPointer = pointer;
                    pointer = pointer.next;
                }
                prevPointer.next = pointer.next;
                pointer = null;
            }
        }

        public void changePerformance(string name, string newPerformance) // Changes the performance of the student to newPerformance
        {
            Node pointer = head;
            
            if (head == null)
                Console.WriteLine("Student doesnt exists");
            else
            {
                while (pointer != null && pointer.studentName != name)
                    pointer = pointer.next;
                if (pointer == null) 
                    Console.WriteLine("Student named "+name+" doesnot exists in the list");
                else
                    pointer.eventCategory = newPerformance;                
            }
        }

        public void swapPerformance() // Changes second performance with last
        {
            Node secondPerformance;
            Node pointer = head;

            if (head == null)
                Console.WriteLine("List is empty");
            else
            {
                secondPerformance = head.next;
                while (pointer.next != null)
                    pointer = pointer.next;                
                
                //store second node's details in name and performance
                string name=secondPerformance.studentName;
                string performance = secondPerformance.eventCategory;

                //set second node's details as last node's
                secondPerformance.studentName = pointer.studentName;
                secondPerformance.eventCategory = pointer.eventCategory;

                //set last node's details to the ones stored in temporary variables.
                pointer.studentName= name;
                pointer.eventCategory = performance;               
            }
        }

        public void display()
        {
            Node pointer = head;
            if (pointer == null)
            {
                Console.WriteLine("List empty \n");
                return;
            }

            while (pointer != null)
            {
                Console.Write(pointer.studentName + "-" + pointer.eventCategory + "---->");
                pointer = pointer.next;
            }
            Console.WriteLine("Null\n");
        }

        public int howMany()
        {
            Node pointer = head;
            int cnt = 0;           

            while (pointer != null)
            {
                cnt++;
                pointer = pointer.next;
            }
            return cnt;
        }
    }
}
