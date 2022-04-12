using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_solve
{
    public class Es_MergeTwoSortedLists
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("List 1");
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(3);
            l1.next.next = new ListNode(5);

            Console.WriteLine("List 2");
            ListNode l2 = new ListNode(2);
            l2.next = new ListNode(4);
            l2.next.next = new ListNode(6);

            Console.WriteLine("sorted list", mergeTwoLists(l1,l2));

        }

        public static ListNode mergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode tempNode = new ListNode(-1);
            ListNode currentNode = tempNode;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tempNode.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tempNode.next = list2;
                    list2 = list2.next;
                }

                tempNode = tempNode.next;
            }

            if(list1 != null)
            {
                tempNode.next = list1;
            }
            if (list2 != null)
            {
                tempNode.next = list2;
            }

            return currentNode.next;
        }

    }

    public class ListNode
    {
     public int val;
     public ListNode next;
     public ListNode() { }
     public ListNode(int val) { this.val = val; }
     public ListNode(int val, ListNode next) { this.val = val; this.next = next; }
     }
}
