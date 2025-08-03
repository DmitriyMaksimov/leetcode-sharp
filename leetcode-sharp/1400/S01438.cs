namespace leetcode_sharp;

// 1438. Longest Continuous Subarray With Absolute Diff Less Than or Equal to Limit
// https://leetcode.com/problems/longest-continuous-subarray-with-absolute-diff-less-than-or-equal-to-limit
public class S01438
{
    public int LongestSubarray(int[] nums, int limit)
    {
        var max = new LinkedList<int>();
        var min = new LinkedList<int>();
        var i = 0;
        var j = 0;
        var longest = 0;

        while (j < nums.Length)
        {
            while (max.Count > 0 && nums[max.Last!.Value] <= nums[j])
            {
                max.RemoveLast();
            }

            max.AddLast(j);

            while (min.Count > 0 && nums[min.Last!.Value] >= nums[j])
            {
                min.RemoveLast();
            }

            min.AddLast(j);

            while (nums[max.First!.Value] - nums[min.First!.Value] > limit)
            {
                i++;
                if (max.First.Value < i)
                {
                    max.RemoveFirst();
                }

                if (min.First.Value < i)
                {
                    min.RemoveFirst();
                }
            }

            longest = Math.Max(longest, j - i + 1);
            j++;
        }

        return longest;
    }
}