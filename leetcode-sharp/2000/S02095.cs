namespace leetcode_sharp;

// 2095. Delete the Middle Node of a Linked List
// https://leetcode.com/problems/delete-the-middle-node-of-a-linked-list/
public class S02095
{
    public ListNode? DeleteMiddle(ListNode? head)
    {
        if (head?.next == null)
        {
            return null;
        }

        var slowPointer = head;
        var fastPointer = head.next;

        while (fastPointer.next?.next != null)
        {
            slowPointer = slowPointer!.next;
            fastPointer = fastPointer.next.next;
        }

        slowPointer!.next = slowPointer.next!.next;

        return head;
    }
}