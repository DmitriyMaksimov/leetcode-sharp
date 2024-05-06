namespace leetcode_sharp;

// 2487. Remove Nodes From Linked List
// https://leetcode.com/problems/remove-nodes-from-linked-list
public class S02487
{
    public ListNode? RemoveNodes(ListNode? head)
    {
        if (head == null) return null;
        
        head.next = RemoveNodes(head.next);

        var nextNode = head.next;

        return nextNode != null && head.val < nextNode.val ? nextNode : head;
    }
}