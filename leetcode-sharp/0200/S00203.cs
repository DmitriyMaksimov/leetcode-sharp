namespace leetcode_sharp;

// 203. Remove Linked List Elements
// https://leetcode.com/problems/remove-linked-list-elements/
public class S00203
{
    public ListNode? RemoveElements(ListNode? head, int val)
    {
        ListNode? newHead = null;
        ListNode? currentNode = null;

        while (head != null)
        {
            if (head.val != val)
            {
                if (newHead == null)
                {
                    newHead = head;
                    currentNode = head;
                }
                else
                {
                    currentNode!.next = head;
                    currentNode = currentNode.next;
                }
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