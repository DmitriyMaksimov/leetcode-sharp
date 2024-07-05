namespace leetcode_sharp;

// 2058. Find the Minimum and Maximum Number of Nodes Between Critical Points
// https://leetcode.com/problems/find-the-minimum-and-maximum-number-of-nodes-between-critical-points
public class S02058
{
    public int[] NodesBetweenCriticalPoints(ListNode head)
    {
        var first = int.MaxValue;
        var last = 0;
        var prevVal = head.val;
        var minD = int.MaxValue;

        for (int i = 0; head.next != null; ++i)
        {
            if ((prevVal < head.val && head.val > head.next.val) || (prevVal > head.val && head.val < head.next.val))
            {
                if (last != 0)
                {
                    minD = Math.Min(minD, i - last);
                }

                first = Math.Min(first, i);
                last = i;
            }

            prevVal = head.val;
            head = head.next;
        }

        return minD == int.MaxValue ? [-1, -1] : [minD, last - first];
    }
}