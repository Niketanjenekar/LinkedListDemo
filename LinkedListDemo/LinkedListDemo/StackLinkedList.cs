﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class StackLinkedList
    {
        public Node top;
        public StackLinkedList() 
        {
            top = null;
        }
        public void push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;
            //Console.WriteLine("Elements in Stack " + data);
        }

        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        //Will return top but will not ddelete the data.
        public void Peek()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is Empty ");
                return;
            }
            Console.WriteLine("The Element at the Top is : ");
            Console.WriteLine(top.data);
            
        }

        //Will return the top value and removes the data.
        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty ");
                return;
            }
            Console.WriteLine("The Element at the Top is : ");
            Console.WriteLine(top.data);
            top = top.next;
        }
    }
}
