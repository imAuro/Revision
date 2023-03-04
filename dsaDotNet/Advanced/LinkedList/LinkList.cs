using System;
namespace dsaDotNet.Advanced.LinkedList
{
	public static class LinkList
	{
        public static void insert_node(int position, int value)
        {
            if (position > size + 1) return;

            if (position == 1)
            {
                TreeNode t = new TreeNode(value);
                t.next = head;
                head = t;
            }

            else
            {
                TreeNode t = head;
                while (position > 2)
                {

                    t = t.next;
                    position--;
                }
                TreeNode tNext = new TreeNode(value);
                tNext.next = t.next;
                t.next = tNext;
            }

            size++;
        }

        public static void delete_node(int position)
        {
            // @params position, integer
            if (position > size) return;

            if (position == 1)
            {
                head = head.next;
            }
            else
            {

                TreeNode h = head;
                while (position > 2)
                {

                    h = h.next;
                    position--;
                }

                h.next = h.next.next;

            }

            size--;
        }

        public static void print_ll()
        {
            // Output each element followed by a space
            TreeNode t = head;
            while (t != null)
            {
                if (t.next == null)
                {
                    Console.Write(t.val);
                }
                else
                {
                    Console.Write(t.val + " ");
                }
                t = t.next;
            }
        }

        public static TreeNode head = null;
        public static int size = 0;
        public class TreeNode
        {
            public TreeNode next;
            public int val;
            public TreeNode(int val)
            {
                this.val = val;
                this.next = null;
            }
        }

    }
}

