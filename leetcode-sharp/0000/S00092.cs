namespace leetcode_sharp;

// 92. Reverse Linked List II
// https://leetcode.com/problems/reverse-linked-list-ii/
public class S00092
{
    public ListNode? ReverseBetween(ListNode? head, int left, int right)
    {
        if (head == null)
        {
            return null;
        }

        if (head.next == null)
        {
            return head;
        }

        var dummy = new ListNode(0)
        {
            next = head
        };

        var previous = dummy;

        for (var i = 0; i < left - 1; i++)
        {
            previous = previous!.next;
        }

        var current = previous!.next;

        for (var i = 0; i < right - left; i++)
        {
            var forward = current!.next;
            current.next = forward!.next;
            forward.next = previous.next;
            previous.next = forward;
        }

        return dummy.next;
    }
}