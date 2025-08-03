namespace leetcode_sharp;

// 2. Add Two Numbers
// https://leetcode.com/problems/add-two-numbers
public class S00002
{
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var carry = 0;
        ListNode? result = null;
        ListNode? lastNode = null;

        while (l1 != null || l2 != null)
        {
            var val1 = l1?.val ?? 0;
            var val2 = l2?.val ?? 0;
            var sum = val1 + val2 + carry;
            if (sum >= 10)
            {
                carry = 1;
                sum -= 10;
            }
            else
            {
                carry = 0;
            }

            var node = new ListNode(sum);

            if (result == null)
            {
                result = node;
            }
            else
            {
                lastNode!.next = node;
            }

            lastNode = node;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (carry > 0)
        {
            lastNode!.next = new ListNode(carry);
        }

        return result;
    }
}
