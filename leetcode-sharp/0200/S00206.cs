namespace leetcode_sharp;

// 206. Reverse Linked List
// https://leetcode.com/problems/reverse-linked-list/
public class S00206
{
    public ListNode? ReverseList(ListNode? head)
    {
        if (head?.next == null)
        {
            return head;
        }

        var previous = head;
        var current = head.next;
        head.next = null;

        while (current != null)
        {
            var next = current.next;
            (current.next, previous) = (previous, current);

            current = next;
        }
        
        return previous;
    }
}