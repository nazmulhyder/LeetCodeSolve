using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    public class Es83_RemoveDuplicate
    {
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddToLinkedList(2);
            linkedList.AddToLinkedList(3);
            linkedList.AddToLinkedList(4);
            linkedList.AddToLinkedList(5);
            linkedList.AddToLinkedList(6);
            linkedList.DisplayAllItems();
        }
    }


    public class LinkedListNode
    {
        public int val;
        public LinkedListNode next;

        public LinkedListNode(int val = 0, LinkedListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class LinkedList
    {
        public LinkedListNode main_list;

        public void AddToLinkedList(int val)
        {
            LinkedListNode node = new LinkedListNode(val);

            if (main_list == null)
            {
                node.next = null;
                main_list = node;
            }
            else
            {
                LinkedListNode tmpNode = main_list;
                node.next = tmpNode;
                main_list = node;
            }

        }

        public void DisplayAllItems()
        {
            LinkedListNode current = main_list;
            while (current != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
        }
    }
}
