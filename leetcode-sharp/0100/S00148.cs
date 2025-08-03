namespace leetcode_sharp;

// 148. Sort List
// https://leetcode.com/problems/sort-list/
public class S00148
{
    public ListNode? SortList(ListNode? head)
    {
        if (head?.next == null)
        {
            return head;
        }

        var slow = head;
        var fast = head;
        ListNode? prev = null;

        while (fast?.next != null)
        {
            prev = slow;
            slow = slow?.next;
            fast = fast.next.next;
        }

        prev!.next = null;
        var l1 = SortList(head);
        var l2 = SortList(slow);

        return mergeSort(l1, l2);
    }

    private static ListNode? mergeSort(ListNode? l1, ListNode? l2)
    {
        ListNode? fh = null;
        ListNode? ft = null;

        while (l1 != null && l2 != null)
        {
            if (fh == null && ft == null)
            {
                if (l1.val > l2.val)
                {
                    fh = l2;
                    ft = l2;
                    l2 = l2.next;
                }
                else
                {
                    fh = l1;
                    ft = l1;
                    l1 = l1.next;
                }
            }

            if (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    ft!.next = l1;
                    ft = ft.next;
                    l1 = l1.next;
                }
                else
                {
                    ft!.next = l2;
                    ft = ft.next;
                    l2 = l2.next;
                }
            }
        }

        if (l1 != null)
        {
            ft!.next = l1;
        }

        if (l2 != null)
        {
            ft.next = l2;
        }

        return fh;
    }
}