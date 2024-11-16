namespace leetcode_sharp;

// 3254. Find the Power of K-Size Subarrays I
// https://leetcode.com/problems/find-the-power-of-k-size-subarrays-i
public class S03254
{
    public int[] ResultsArray(int[] nums, int k)
    {
        var n = nums.Length;
        var result = Enumerable.Repeat(-1, n - k + 1).ToArray();
        var score = 0;

        for (var i = 0; i < n; i++)
        {
            if (i > 0 && nums[i - 1] + 1 == nums[i])
            {
                score++;
            }
            else
            {
                score = 0;
            }

            if (score >= k - 1)
            {
                result[i - k + 1] = nums[i];
            }
        }

        return result;
    }
}
