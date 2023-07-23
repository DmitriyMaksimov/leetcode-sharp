namespace leetcode_sharp;

// 19. Remove Nth Node From End of List
// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
public class S00019
{
    public ListNode? RemoveNthFromEnd(ListNode? head, int n)
    {
        if (head?.next == null)
        {
            return null;
        }

        var current = head;
        var nodeToDelete = head;
        var nodePrevToDelete = head;

        while (current != null)
        {
            current = current.next;
            if (n > 0)
            {
                --n;
            }
            else
            {
                nodePrevToDelete = nodeToDelete;
                nodeToDelete = nodeToDelete?.next;
            }
        }

        if (nodeToDelete != head)
        {
            nodePrevToDelete.next = nodeToDelete?.next;
        }
        else
        {
            return nodeToDelete.next;
        }

        return head;
    }
}