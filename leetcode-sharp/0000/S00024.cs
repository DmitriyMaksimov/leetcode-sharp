namespace leetcode_sharp;

// 24. Swap Nodes in Pairs
// https://leetcode.com/problems/swap-nodes-in-pairs/
public class S00024
{
    public ListNode? SwapPairs(ListNode? head)
    {
        if (head?.next == null)
        {
            return head;
        }

        var dummyNode = new ListNode();
        var prevNode = dummyNode;
        var currNode = head;

        while (currNode?.next != null)
        {
            prevNode.next = currNode.next;
            currNode.next = prevNode.next.next;
            prevNode.next.next = currNode;

            prevNode = currNode;
            currNode = currNode.next;
        }

        return dummyNode.next;
    }
}