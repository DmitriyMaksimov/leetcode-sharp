namespace leetcode_sharp;

// 3217. Delete Nodes From Linked List Present in Array
// https://leetcode.com/problems/delete-nodes-from-linked-list-present-in-array
public class S03217
{
    public ListNode? ModifiedList(int[] nums, ListNode? head)
    {
        var tempNode = new ListNode(0, head);
        var hashSet = nums.ToHashSet();

        for (var node = tempNode; node.next != null;)
        {
            if (hashSet.Contains(node.next.val))
            {
                node.next = node.next.next;
            }
            else
            {
                node = node.next;
            }
        }

        return tempNode.next;
    }
}
