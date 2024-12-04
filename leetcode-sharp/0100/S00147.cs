namespace leetcode_sharp;

// 147. Insertion Sort List
// https://leetcode.com/problems/insertion-sort-list
public class S00147
{
    public ListNode? InsertionSortList(ListNode? head)
    {
        if (head == null)
        {
            return head;
        }

        var dummy = new ListNode();
        var current = head;
        var previous = dummy;

        while (current != null)
        {
            var next = current.next;

            while (previous.next != null && previous.next.val < current.val)
            {
                previous = previous.next;
            }

            current.next = previous.next;
            previous.next = current;
            previous = dummy;
            current = next;
        }

        return dummy.next;
    }
}
