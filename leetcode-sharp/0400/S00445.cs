namespace leetcode_sharp;

// 445. Add Two Numbers II
// https://leetcode.com/problems/add-two-numbers-ii/
public class S00445
{
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var digits1 = toDigits(l1);
        var digits2 = toDigits(l2);

        var maxDigits = Math.Max(digits1.Count, digits2.Count);

        var sum = new List<int>(maxDigits + 1);

        var carry = 0;
        
        for (var i = 0; i < maxDigits; i++)
        {
            var d1 = digits1.ElementAtOrDefault(i);
            var d2 = digits2.ElementAtOrDefault(i);

            var s = d1 + d2 + carry;
            carry = s / 10;
            sum.Add(s % 10);
        }

        if (carry != 0)
        {
            sum.Add(carry);
        }

        ListNode? result = null;
        
        foreach (var digit in sum)
        {
            result = new ListNode(digit, result);
        }
        
        return result;
    }

    private static List<int> toDigits(ListNode? root)
    {
        var digits = new List<int>();
        while (root != null)
        {
            digits.Add(root.val);
            root = root.next;
        }

        digits.Reverse();

        return digits;
    }
}