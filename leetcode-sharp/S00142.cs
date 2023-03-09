namespace leetcode_sharp;

// 142. Linked List Cycle II
// https://leetcode.com/problems/linked-list-cycle-ii/
public class S00142
{
    public ListNode? DetectCycle(ListNode? head)
    {
        var slowPointer = head;
        var fastPointer = head;
        var loopExist = false;

        while (slowPointer != null && fastPointer?.next != null)
        {
            fastPointer = fastPointer.next.next;
            slowPointer = slowPointer.next;

            if (fastPointer == slowPointer)
            {
                loopExist = true;
                break;
            }
        }

        if (!loopExist)
        {
            return null;
        }
        
        // reset slow pointer to head and loop again
        slowPointer = head;
        while (slowPointer != fastPointer)
        {
            slowPointer = slowPointer!.next;
            fastPointer = fastPointer!.next;
        }
 
        return slowPointer;
    }
}