namespace leetcode_sharp;

// 876. Middle of the Linked List
// https://leetcode.com/problems/middle-of-the-linked-list/description/
public class S00876
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode MiddleNode(ListNode head)
    {
        var fast = head;
        var slow = head;

        while (fast?.next != null)
        {
            fast = fast.next?.next;
            slow = slow.next;
        }

        return slow;
    }
}