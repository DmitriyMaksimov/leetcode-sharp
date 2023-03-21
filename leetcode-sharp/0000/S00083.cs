namespace leetcode_sharp;

// 83. Remove Duplicates from Sorted List
// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
public class S00083
{
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        if (head == null)
        {
            return null;
        }
        
        var newHead = head;
        var currentNode = head;
        var prevVal = head.val;
        head = head.next;

        while (head != null)
        {
            if (head.val != prevVal)
            {
                currentNode.next = head;
                currentNode = currentNode.next;
                prevVal = head.val;
            }

            head = head.next;
        }

        if (currentNode != null)
        {
            currentNode.next = null;
        }
        
        return newHead;
    }
}