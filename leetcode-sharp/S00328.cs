namespace leetcode_sharp;

// 328. Odd Even Linked List
// https://leetcode.com/problems/odd-even-linked-list/
public class S00328
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode OddEvenList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        var second = head?.next;
        var currentOdd = head;
        var currentNode = second?.next;
        var currentEven = second;
        var isOdd = true;

        while (currentNode != null)
        {
            if (isOdd)
            {
                if (currentOdd != null)
                {
                    currentOdd.next = currentNode;
                    currentOdd = currentNode;
                }
            }
            else
            {
                if (currentEven != null)
                {
                    currentEven.next = currentNode;
                    currentEven = currentNode;
                }
            }

            currentNode = currentNode?.next;

            isOdd = !isOdd;
        }

        currentOdd.next = second;
        if (currentEven != null) currentEven.next = null;

        return head;
    }
}