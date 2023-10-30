using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6_Bai1
{
    internal class Program
    {
        public class Node
        {
            public object element;
            public Node link;
            public Node()
            {
                element = null;
                link = null;
            }
            public Node(object element)
            {
                this.element = element;
                link = null;
            }
        }
        public class LinkedList
        {
            public Node header;
            public LinkedList()
            {
                header = new Node("Header");
            }
            private Node Find(object element)
            {
                Node current = new Node();
                current = header;
                while (current.element != element)
                    current = current.link;
                return current;
            }
            public void Insert(object newelement, object afterelement)
            {
                Node current = new Node();
                Node newnode = new Node(newelement);
                current = Find(afterelement);
                newnode.link = current.link;
                current.link = newnode;
            }
            public Node FindPrev(object element)
            {
                Node current = header;
                while (current.link != null && current.link.element != element)
                    current = current.link;
                return current;
            }
            public void Remove(object element)
            {
                Node current = FindPrev(element);
                if (current.link != null)
                    current.link = current.link.link;
            }
            public void Print()
            {
                Node current = new Node();
                current = header;
                while (current.link != null)
                {
                    Console.WriteLine(current.link.element);
                    current = current.link;
                }
            }
            public int FindMax()
            {
                Node current = header;
                int max = int.Parse(current.link.element.ToString());
                while (current.link != null)
                {
                    if (int.Parse(current.link.element.ToString()) > max)
                    {
                        max = (dynamic)current.link.element;
                    }
                    current = current.link;
                }
                return max;
            }
            public double Average()
            {
                Node current = header;
                current = current.link;
                double sum = double.Parse(current.element.ToString());
                int count = 1;
                while (current.link != null)
                {
                    int a = int.Parse(current.link.element.ToString());
                    sum += a;
                    count++;
                    current = current.link;
                }
                return sum / (double)count;
            }
        }
        public class Node2
        {
            public object element;
            public Node2 flink, blink;
            public Node2()
            {
                element = null;
                flink = blink = null;
            }
            public Node2(object element)
            {
                this.element = element;
                flink = blink = null;
            }
        }
        public class DoubleLinkedList
        {
            public Node2 header;
            public DoubleLinkedList()
            {
                header = new Node2("Header");
            }
            private Node2 Find(object element)
            {
                Node2 current = new Node2();
                current = header;
                while (current.element != element)
                {
                    current = current.flink;
                }
                return current;
            }
            public void Insert(object newelement, object afterelement)
            {
                Node2 current = new Node2();
                Node2 newnode = new Node2(newelement);
                current = Find(afterelement);
                newnode.flink = current.flink;
                newnode.blink = current;
                current.flink = newnode;
            }
            public void Remove(object element)
            {
                Node2 current = Find(element);
                if (current.flink != null)
                {
                    current.blink.flink = current.flink;
                    current.flink.blink = current.blink;
                    current.flink = null;
                    current.blink = null;
                }
            }
            public void Print()
            {
                Node2 current = new Node2();
                current = header;
                while (current.flink != null)
                {
                    Console.WriteLine(current.flink.element);
                    current = current.flink;
                }
            }
            public int FindMax()
            {
                Node2 current = header;
                int max = int.Parse(current.flink.element.ToString());
                while (current.flink != null)
                {
                    if (int.Parse(current.flink.element.ToString()) > max)
                    {
                        max = (dynamic)current.flink.element;
                    }
                    current = current.flink;
                }
                return max;
            }
            public double Average()
            {
                Node2 current = header;
                current = current.flink;
                double sum = double.Parse(current.element.ToString());
                int count = 1;
                while (current.flink != null)
                {
                    int a = int.Parse(current.flink.element.ToString());
                    sum += a;
                    count++;
                    current = current.flink;
                }
                return sum / (double)count;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--Đây là Danh Sách Liên kết đơn-");
            LinkedList list = new LinkedList();
            list.Insert("1", "Header");
            list.Insert("2", "1");
            list.Insert("3", "2");
            list.Insert("4", "3");
            list.Insert("5", "4");
            list.Print();
            Console.WriteLine("Max:" + " " + list.FindMax());
            Console.WriteLine("AVR:" + " " + list.Average());
            DoubleLinkedList list2 = new DoubleLinkedList();
            Console.WriteLine("-Danh Sách Liên kết đôi-");
            list2.Insert("1", "Header");
            list2.Insert("2", "1");
            list2.Insert("3", "2");
            list2.Insert("4", "3");
            list2.Insert("5", "4");
            list2.Print();
            Console.WriteLine("Max:" + " " + list2.FindMax());
            Console.WriteLine("Avr:" + " " + list2.Average());
            Console.WriteLine("-Danh Sách Liên kết của NET-");
            LinkedList<int> names = new LinkedList<int>();
            names.AddFirst(1);
            names.AddLast(2);
            names.AddLast(3);
            names.AddLast(4);
            names.AddLast(5);
            LinkedListNode<int> node = names.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            Console.WriteLine("Max:" + " " + names.Max());
            Console.WriteLine("Avr:" + " " + names.Average());
            Console.ReadKey();
        }
    }
}
