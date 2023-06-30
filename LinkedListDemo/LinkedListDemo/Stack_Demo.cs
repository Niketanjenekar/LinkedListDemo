using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class Stack_Demo
    {
        public void Element()
        {
            //Last-In First_Out
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2.36);
            stack.Push("Jenekar");
            stack.Push(4);
            stack.Push('b');
            stack.Push("Niketan");
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Contains("Niketan"));
            Console.WriteLine(stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
