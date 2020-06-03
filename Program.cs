using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList llist = new LinkedList();
            llist.Append(6);
            llist.push(7);
            llist.push(1);
            llist.Append(4);
            llist.InsertAfter(llist.head.next, 8);
            Console.Write("the created linked list is");
            llist.PrintList();
            llist.Delete(7);
            Console.WriteLine();
            llist.PrintList();
            Console.WriteLine();
            llist.DeleteAtAPosition(2);
            llist.PrintList();
            llist.LengthOfALinkedList();
            Console.WriteLine(llist.LengthOfALinkedListByRecursion(llist.head));
            Console.ReadLine();

          
        }
       
    }

    public class LinkedList
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }

           
        }
        public void push(int new_data)
        {
            Node newNode = new Node(new_data);
            newNode.next = head;
            head = newNode;

        }

        public void InsertAfter(Node prevNode,int data)
        {
            if(prevNode==null)
            {
                Console.WriteLine("the given node cannot be null");
            }
            Node newNode = new Node(data);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
            
        }
        //add a node at the end
        public void Append(int newdata)
        {
            Node newNode = new Node(newdata);
            if(head==null)
            {
                head = newNode;
                return;
            }
            Node currentNode=head;
            while(currentNode.next!=null)
            {
                currentNode = currentNode.next; 
            }
            currentNode.next = newNode;
            return;     
        }

        //print list

        public void PrintList()
        {
            Node tnode = head;
            while(tnode.next!=null)
            {
                Console.Write(tnode.data+" ");
                tnode = tnode.next;
                
            }
        }
        //delete the first occurence of a given key
        public void Delete(int key)
        {
            Node currentNode = head;
            Node prev = null;
            while(currentNode!=null && currentNode.data!=key)
            {
                prev = currentNode;
                currentNode = currentNode.next;
            }
            if(currentNode==null)
            {
                return;
            }


            prev.next = currentNode.next;
            return;
        }
        //deleted the node at a given position
        public void DeleteAtAPosition(int position)
        {
            Node currentNode = head;
            Node prev = null;
            for (int i=0;i<position-1;i++)
            {
                prev = currentNode;
                currentNode = currentNode.next;
            }
            prev.next = currentNode.next;
        }
        //Length of a linked list
        public void LengthOfALinkedList()
        {
            int count = 0;
            Node current = head;
            while(current.next!=null)
            {
               
                count++;
                current = current.next;
            }
            Console.WriteLine("the count of linked list is" + count);
        }

        public int LengthOfALinkedListByRecursion(Node node)
        {
            Node currentNode=node;
            if(currentNode==null)
            {
                return 0;
            }
            return 1 + LengthOfALinkedListByRecursion(currentNode.next);
        }
        
        //Remove duplicate from linked list
        public void removeduplicates()
        {
            Node currentNode = head;
            while(currentNode==currentNode.next)
            {
                currentNode = currentNode.next;
            }
        }

        
    }
  
}
