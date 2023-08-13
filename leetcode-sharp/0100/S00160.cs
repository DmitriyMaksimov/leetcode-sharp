namespace leetcode_sharp;

// 160. Intersection of Two Linked Lists
// https://leetcode.com/problems/intersection-of-two-linked-lists/
public class S00160
{
    public ListNode? GetIntersectionNode(ListNode? headA, ListNode? headB)
    {
        var nodeA = headA;
        var nodeB = headB;

        while (nodeA != nodeB)
        {
            nodeA = (nodeA == null) ? headB : nodeA.next;
            nodeB = (nodeB == null) ? headA : nodeB.next;
        }

        return nodeA;
    }
}