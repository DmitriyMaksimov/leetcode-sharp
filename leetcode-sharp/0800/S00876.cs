namespace leetcode_sharp;

// 876. Middle of the Linked List
// https://leetcode.com/problems/middle-of-the-linked-list/description/
public class S00876
{
    public ListNode MiddleNode(ListNode head)
    {
        var fast = head;
        var slow = head;

        while (fast?.next != null)
        {
            fast = fast.next?.next;
            slow = slow!.next;
        }

        return slow!;
    }
}