using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class SLL
    {
        public Node Head { get; set; }

        public ulong Count { get; set; }

        


        public bool isEmpty
        {
            get => this.Head == null;
        }

        //LinkedList<string> linkedList = new LinkedList<string>();




        public SLL()
        {
            this.Head = null;
        }

        public void AddFirst(string value)
        {
            //create new node
            Node newNode = new Node();

            //set the value of new node
            newNode.Value = value;

            //set the next node at the head
            Node head = this.Head;

            //set the "NEXT" of new node to node at head
            newNode.Next = head;


            //Set the head to the new node
            this.Head = newNode;

            //increment count
            this.Count = this.Count + 1;
        }

        public void AddLast(string value)
        {
            //create new node
            Node newNode = new Node();

            //set the value of new node
            newNode.Value = value;

            // Add to the Singly Linked List if head is empty
            if (this.isEmpty)
            {
                this.Head = newNode;
            }

            //Move to the last node using a Loop 
            else
            {
                // Get the last node (loop to node with no next)
                Node currentNode = this.Head;

                //variable last node
                Node lastNode;

                
                

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                lastNode = currentNode;
                //Set the next of the last node to newNode
                lastNode.Next = newNode;
            }
            // Increment count
            this.Count++;
        }

        //        •	RemoveFirst() : Removes the first node in the list.
        //•	RemoveLast(): Removes the last node in the list.
        //•	GetValue(int index): Retrieves the value of the node at the given index.

        public bool RemoveFirst(string value)
        {
            // Return false if head is empty
            if (this.isEmpty)
            {
                return false;
            }
            else if (this.Count == 1)
            {
                this.Head = null;
            }
            else
            {
                // Get the current node at the head
                Node currentNodeAtHead = this.Head;

                // Get the next node of the head
                Node newHead = currentNodeAtHead.Next;

                // Set the head to the newHead node
                this.Head = newHead;
            }

            // Count decreases
            this.Count--;

            return true;

        }

        public bool RemoveLast(string value)
        {
            // Return false if head is empty
            if (this.isEmpty)
            {
                return false;
            }
            else if (this.Count == 1)
            {
                this.Head = null;
            }
            else
            {
                // Loop until the previous node of node to delete
                
                //Saying it has only one node
                Node nextNode = this.Head;
                Node previousNode = nextNode;

                while (nextNode.Next != null)
                {
                    previousNode = nextNode;
                    nextNode = nextNode.Next;
                }

                // Set the next of the before last node to null
                previousNode.Next = null;
            }

            // Count decreases
            this.Count--;

            return true;
        }

        //Retrieves the value of the node at the given index.
        public string GetValue(ulong index)
        {

            // Check The linked list is not empty or index greater than the list size
            if (this.isEmpty || index > this.Count)
            {
                return "-1";
            }
            else
            {
                // Loop to get the node in the index provided
                Node currentNode = this.Head;
                ulong count = 1;

                while (count < index)
                {
                    currentNode = currentNode.Next;
                    count++;
                }

                // Return the value of the node
                return currentNode.Value;
            }
        }

    }
}
