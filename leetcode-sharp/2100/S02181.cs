namespace leetcode_sharp;

// 2181. Merge Nodes in Between Zeros
// https://leetcode.com/problems/merge-nodes-in-between-zeros
public class S02181
{
    public ListNode MergeNodes(ListNode head)
    {
        var current = head;

        while (current.next != null)
        {
            var nextNode = current.next;

            var nextNext = nextNode.next;
            nextNode.next = null;

            if (nextNode.val != 0)
            {
                current.val += nextNode.val;
            }
            else if (nextNode.val == 0 && nextNext != null)
            {
                current = nextNode;
            }

            current.next = nextNext;
        }

        return head;
    }
}