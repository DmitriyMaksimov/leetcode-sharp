namespace leetcode_sharp;

// 141. Linked List Cycle
// https://leetcode.com/problems/linked-list-cycle/
public class S00141
{
    public bool HasCycle(ListNode? head)
    {
        var fastLoop = head;

        while (fastLoop?.next != null)
        {
            fastLoop = fastLoop.next.next;
            head = head!.next;
            if (fastLoop == head)
            {
                return true;
            }
        }
        return false;
    }
}