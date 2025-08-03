namespace leetcode_sharp;

// 61. Rotate List
// https://leetcode.com/problems/rotate-list/
public class S00061
{
    public ListNode? RotateRight(ListNode? head, int k)
    {
        if (head == null)
        {
            return head;
        }

        var len = 1;
        var curr = head;

        while (curr.next != null)
        {
            curr = curr.next;
            len++;
        }

        k %= len;
        
        if (k == 0)
        {
            return head;
        }

        curr.next = head;
        
        var newHead = head;
        
        for (var i = 0; i < len - k - 1; i++)
        {
            newHead = newHead!.next;
        }

        var temp = newHead!.next;
        newHead.next = null;
        
        return temp;
    }
}