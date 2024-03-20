namespace leetcode_sharp;

// 1669. Merge In Between Linked Lists
// https://leetcode.com/problems/merge-in-between-linked-lists
public class S01669
{
    public ListNode? MergeInBetween(ListNode list1, int a, int b, ListNode list2)
    {
        var start = list1;
        
        for (var i = 0; i < a - 1; i++)
        {
            start = start?.next;
        }

        var end = start;
        for (var i = a; i <= b; i++)
        {
            end = end?.next;
        }

        start.next = list2;

        while (list2.next != null)
        {
            list2 = list2.next;
        }

        list2.next = end?.next;

        return list1;
    }
}