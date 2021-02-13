using System;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node previous;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            previous = null;
            next = null;
        }
    }

    public class LinkedList
    {
        private Node head;
        public int Count { get; }

        public LinkedList()
        {
            Count = 0;

            head = null;
        }

        public void Insert(Node node)
        {
            if (head == null)
            {
                head = node;
                return;
            }

            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = node;
            node.previous = temp;
        }

        public void Show()
        {
            Node temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();

            Node n0 = new Node(0);
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);

            myList.Insert(n0);
            myList.Insert(n1);
            myList.Insert(n2);
            myList.Insert(n3);
            myList.Insert(n4);
            myList.Insert(n5);
            myList.Insert(n6);

            myList.Show();
        }
    }
}