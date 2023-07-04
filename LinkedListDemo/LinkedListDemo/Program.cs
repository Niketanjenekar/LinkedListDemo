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
            Linked_List_Node linked_List_Node = new Linked_List_Node();
            while (true)
            {
                Console.WriteLine("Please Select the Option: ");
                Console.WriteLine("1. Linked_List_Demo");
                Console.WriteLine("2. Stack_Demo");
                Console.WriteLine("3. Queue_Demo");
                Console.WriteLine("4. Linked_List_Node");
                Console.WriteLine("5. Reverse the Order");
                Console.WriteLine("6. Remove the First Element");
                Console.WriteLine("7. Remove the Last Element");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Welcome to Linked List");
                        Linked linked = new Linked();
                        linked.List();
                        break;
                    case 2:
                        Console.WriteLine("Welcome to Stack ");
                        Stack_Demo stack = new Stack_Demo();
                        stack.Element();
                        break;
                    case 3:
                        Console.WriteLine("Welcomr to Queue ");
                        Queue queue = new Queue();

                        break;
                    case 4:
                        Console.WriteLine("Welcome to Linked List Node");
                        
                        linked_List_Node.Add(4);
                        linked_List_Node.Display();
                        linked_List_Node.Add(6);
                        linked_List_Node.Display();
                        linked_List_Node.Add(9);
                        linked_List_Node.Display();
                        break;
                    case 5:
                        linked_List_Node.Reverse_Order(40);
                        linked_List_Node.Reverse_Order(60);
                        linked_List_Node.Reverse_Order(88);
                        linked_List_Node.Reverse_Order(91);
                        linked_List_Node.Display();
                        break;
                    case 6:
                        linked_List_Node.Empty_First();
                        linked_List_Node.Display();
                        break;
                    case 7:
                        linked_List_Node.Empty_Last();
                        linked_List_Node.Display();
                        break;
                    default:
                        Console.WriteLine("Please enter the Valid Option");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
