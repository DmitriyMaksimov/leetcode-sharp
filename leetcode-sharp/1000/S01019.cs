namespace leetcode_sharp;

// 1019. Next Greater Node In Linked List
// https://leetcode.com/problems/next-greater-node-in-linked-list
public class S01019
{
    public int[] NextLargerNodes(ListNode? head)
    {
        List<int> res = [];
        var stack = new Stack<int>();

        for (var p = head; p != null; p = p.next)
        {
            res.Add(p.val);
        }

        for (var i = res.Count - 1; i >= 0; --i)
        {
            var val = res[i];
            while (stack.Count != 0 && stack.Peek() <= res[i])
            {
                stack.Pop();
            }

            res[i] = stack.Count != 0 ? stack.Peek() : 0;
            stack.Push(val);
        }

        return res.ToArray();
    }
}
