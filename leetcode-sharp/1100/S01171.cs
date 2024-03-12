namespace leetcode_sharp;

// 1171. Remove Zero Sum Consecutive Nodes from Linked List
// https://leetcode.com/problems/remove-zero-sum-consecutive-nodes-from-linked-list
public class S01171
{
    public ListNode? RemoveZeroSumSublists(ListNode? head)
    {
        var dummy = new ListNode();
        var current = dummy;
        dummy.next = head;
        
        var prefix = 0;
        Dictionary<int, ListNode> m = [];
        
        while (current != null)
        {
            prefix += current.val;

            if (!m.TryAdd(prefix, current))
            {
                current = m[prefix].next;
                var p = prefix + current!.val;
                while (p != prefix)
                {
                    m.Remove(p);
                    current = current.next;
                    p += current!.val;
                }

                m[prefix].next = current.next;
            }

            current = current.next;
        }

        return dummy.next;
    }
}