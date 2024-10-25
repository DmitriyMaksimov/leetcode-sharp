namespace leetcode_sharp;

// 430. Flatten a Multilevel Doubly Linked List
// https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list
public class S00430
{
    public class Node
    {
        public int val;
        public Node? prev;
        public Node? next;
        public Node? child;
    }

    public Node? Flatten(Node? head)
    {
        for (var h = head; h != null; h = h.next)
        {
            if (h.child == null)
            {
                continue;
            }

            var next = h.next;
            h.next = h.child;
            h.next.prev = h;
            h.child = null;

            var p = h.next;
            while (p.next != null)
            {
                p = p.next;
            }

            p.next = next;
            if (next != null)
            {
                next.prev = p;
            }
        }

        return head;
    }
}
