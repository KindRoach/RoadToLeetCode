using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _328_OddEvenLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(1);
            var p = head;
            for (int i = 2; i < 4; i++)
            {
                p.next = new ListNode(i);
                p = p.next;
            }
            OddEvenList(head);
            return;
        }

        static ListNode OddEvenList(ListNode head)
        {
            if (head == null ||
                head.next == null ||
                head.next.next == null)
                return head;
            ListNode lastOdd, firstEven, lastEven;
            lastOdd = head;
            firstEven = lastEven = head.next;
            while (lastEven != null && lastEven.next != null)
            {
                lastOdd.next = lastOdd.next.next;
                lastEven.next = lastEven.next.next;
                lastOdd = lastOdd.next;
                lastEven = lastEven.next;
            }
            lastOdd.next = firstEven;
            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
