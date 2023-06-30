using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List");
            Linked linked = new Linked();
            linked.List();

            Stack_Demo stack = new Stack_Demo();
            stack.Element();
            Console.ReadLine();
        }
    }
}
