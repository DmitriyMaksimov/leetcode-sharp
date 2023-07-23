namespace leetcode_sharp;

// 2130. Maximum Twin Sum of a Linked List
// https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
public class S02130
{
    public int PairSum(ListNode? head)
    {
        if (head == null)
        {
            return 0;
        }

        if (head.next == null)
        {
            return head.val;
        }

        var slow = head;
        var fast = head;

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        slow = reverse(slow);
        fast = head;
        var sum = int.MinValue;
        
        while (slow != null)
        {
            sum = Math.Max(slow.val + fast.val, sum);
            slow = slow.next;
            fast = fast.next;
        }

        return sum;
    }

    private static ListNode? reverse(ListNode? node)
    {
        if (node == null)
        {
            return null;
        }

        var current = node;
        ListNode previous = null;
        while (current != null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }
}