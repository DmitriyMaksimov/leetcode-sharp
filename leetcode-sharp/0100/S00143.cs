namespace leetcode_sharp;

// 143. Reorder List
// https://leetcode.com/problems/reorder-list
public class S00143
{
    public void ReorderList(ListNode? head)
    {
        if (head?.next?.next == null)
        {
            return;
        }

        Stack<ListNode> stack = [];
        var current = head;
        var size = 0;

        while (current != null)
        {
            stack.Push(current);
            size++;
            current = current.next;
        }

        current = head;

        for (var j = 0; j < size / 2; j++)
        {
            var element = stack.Pop();
            element.next = current!.next;
            current!.next = element;
            current = current.next.next;
        }

        current!.next = null;
    }
}