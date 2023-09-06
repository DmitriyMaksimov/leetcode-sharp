namespace leetcode_sharp;

// 725. Split Linked List in Parts
// https://leetcode.com/problems/split-linked-list-in-parts/
public class S00725
{
    public ListNode?[] SplitListToParts(ListNode? head, int k)
    {
        var result = new ListNode?[k];
        var length = 0;
        var current = head;
        while (current != null)
        {
            length++;
            current = current.next;
        }

        var partLength = length / k;
        var remainder = length % k;
        current = head;
        for (var i = 0; i < k; i++)
        {
            var part = current;
            var partLengthTemp = partLength;
            if (remainder > 0)
            {
                partLengthTemp++;
                remainder--;
            }

            for (var j = 0; j < partLengthTemp - 1; j++)
            {
                current = current?.next;
            }

            if (current != null)
            {
                var temp = current.next;
                current.next = null;
                current = temp;
            }

            result[i] = part;
        }

        return result;
    }
}