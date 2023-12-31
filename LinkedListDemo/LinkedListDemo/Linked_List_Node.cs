﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class Linked_List_Node
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("The Linked List data is " + data);
        }

        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
            }

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            
        }

        public void Reverse_Order(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.next = temp;
            }
        }

        public void Empty_First()
        {
            if(head == null)
            {
                Console.WriteLine("List is Empty");
            }
            head = head.next;
            Console.WriteLine("First Element is Removed");
        }

        public void Empty_Last()
        {
            if(head == null)
            {
                Console.WriteLine("The List is Empty");
            }
            if(head.next == null)
            {
                Console.WriteLine("it only Contains single element");
            }
            else
            {
                Node temp = head;
                while(temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.WriteLine("The Last Element is Deleted");
            }
        }

        public void Size()
        {
            if (head == null)
            {
                Console.WriteLine("The List is Empty");
            }
            else
            {
                Node temp = head;
                int count = 1;
                while(temp.next != null)
                {
                    count++;
                    temp = temp.next;
                }
                Console.WriteLine("The Length of Linked_List is " + count);
            }
        }

        public int Search(int value)
        {
            Node node = head;
            if(node == null)
            {
                return -1;
            }
            int count = 1;
            while(node != null)
            {
                if(node.data == value)
                {
                    return count;
                }
                else
                {
                    Console.WriteLine("The Element not Found");
                }
                node = node.next;
                count++;
            }
            return count;
        }
    }
}
