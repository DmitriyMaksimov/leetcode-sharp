namespace leetcode_sharp;

// 82. Remove Duplicates from Sorted List II
// https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
public class S00082
{
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        var dummy = new ListNode(0, head);
        var prev = dummy;

        while (head != null)
        {
            if (head.next != null && head.val == head.next.val)
            {
                while (head.next != null && head.val == head.next.val)
                {
                    head = head.next;
                }

                prev.next = head.next;
            }
            else
            {
                prev = prev.next;
            }

            head = head.next;
        }

        return dummy.next;
    }
}