namespace leetcode_sharp;

// 1290. Convert Binary Number in a Linked List to Integer
// https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/description/
public class S01290
{
    public int GetDecimalValue(ListNode? head)
    {
        var result = 0;

        while (head != null)
        {
            result *= 2;
            result += head.val;
            head = head.next;
        }
        
        return result;
    }
}