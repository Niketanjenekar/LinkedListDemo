﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{

    public class Linked
    {
        //Linked List is a linear dta structure which stores the elemnt in the non-contagious Location.
        //The Node had element are Linked with each other using pointer.
        //Linked List class allows insertion and deletion of element from list very fastly.
        //Node- node will be your exact value
        //next-reference of the next node
        public void List()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);
            list.AddLast(8);
            list.AddLast(9);
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            foreach (int val in list)
            {
                Console.WriteLine("Elements in the list is "+ val);
            }
            if (list.Contains(5) == true)
            {
                Console.WriteLine("Element is Present");
            }
            else
            {
                Console.WriteLine("Element is not Present");
            }
            list.Remove(4);
            foreach (int val in list)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("Count is "+  list.Count);

            //list.Clear();
            foreach (int val in list)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("Count is "+ list.Count);
            list.Remove(5);
            foreach (int val in list)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("Count is " + list.Count);
        }
    }
}
