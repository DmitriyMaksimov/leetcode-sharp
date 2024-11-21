namespace leetcode_sharp;

// 817. Linked List Components
// https://leetcode.com/problems/linked-list-components
public class S00817
{
    public int NumComponents(ListNode? head, int[] nums)
    {
        var hashSet = nums.ToHashSet();
        var result = 0;
        var connected = false;

        while (head != null)
        {
            if (hashSet.Contains(head.val))
            {
                if (!connected)
                {
                    result++;
                }

                connected = true;
            }
            else
            {
                connected = false;
            }

            head = head.next;
        }

        return result;
    }
}
