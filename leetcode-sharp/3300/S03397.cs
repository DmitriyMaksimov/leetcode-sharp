namespace leetcode_sharp;

// 3397. Maximum Number of Distinct Elements After Operations
// https://leetcode.com/problems/maximum-number-of-distinct-elements-after-operations
public class S03397
{
    public int MaxDistinctElements(int[] nums, int k)
    {
        Array.Sort(nums);

        var result = 0;
        var prev = int.MinValue;

        foreach (var num in nums)
        {
            var l = Math.Max(num - k, prev + 1);
            if (l <= num + k)
            {
                prev = l;
                result++;
            }
        }

        return result;
    }
}