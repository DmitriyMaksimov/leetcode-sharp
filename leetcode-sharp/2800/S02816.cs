namespace leetcode_sharp;

// 2816. Double a Number Represented as a Linked List
// https://leetcode.com/problems/double-a-number-represented-as-a-linked-list
public class S02816
{
    public ListNode DoubleIt(ListNode head)
    {
        head = head.val >= 5 ? new ListNode(0, head) : head;

        for (var node = head; node != null; node = node.next)
        {
            var carry = node.next is { val: >= 5 } ? 1 : 0;

            node.val = node.val * 2 % 10 + carry;
        }

        return head;
    }
}