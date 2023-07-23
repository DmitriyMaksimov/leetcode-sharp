namespace leetcode_sharp;

// 1721. Swapping Nodes in a Linked List
// https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
public class S01721
{
    public ListNode? SwapNodes(ListNode? head, int k)
    {
        ListNode? node1 = null;
        ListNode? node2 = null;

        for (var p = head; p != null; p = p.next)
        {
            node2 = node2?.next;

            if (--k == 0)
            {
                node1 = p;
                node2 = head;
            }
        }

        (node1.val, node2.val) = (node2.val, node1.val);

        return head;
    }
}