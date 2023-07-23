namespace leetcode_sharp;

// 23. Merge k Sorted Lists
// https://leetcode.com/problems/merge-k-sorted-lists/
public class S00023
{
    public ListNode? MergeKLists(ListNode?[]? lists)
    {
        if (lists == null)
        {
            return null;
        }

        var result = lists.FirstOrDefault();
        
        for (var i = 1; i < lists.Length; i++)
        {
            result = mergeTwoLists(result, lists[i]);
        }
        
        return result;
    }

    private static ListNode? mergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }

        if (list1 == null)
        {
            return list2;
        }

        if (list2 == null)
        {
            return list1;
        }

        var p1 = list1;
        var p2 = list2;

        var dummyNode = new ListNode();

        var tail = dummyNode;

        while (true)
        {
            if (p1 == null)
            {
                tail.next = p2;
                break;
            }

            if (p2 == null)
            {
                tail.next = p1;
                break;
            }

            if (p1.val <= p2.val)
            {
                tail.next = p1;
                p1 = p1.next;
            }
            else
            {
                tail.next = p2;
                p2 = p2.next;
            }

            tail = tail.next;
        }

        return dummyNode.next;
    }
}