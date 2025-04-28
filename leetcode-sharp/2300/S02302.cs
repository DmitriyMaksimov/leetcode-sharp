namespace leetcode_sharp;

// 2302. Count Subarrays With Score Less Than K
// https://leetcode.com/problems/count-subarrays-with-score-less-than-k
public class S02302
{
    public long CountSubarrays(int[] nums, long k)
    {
        var sum = 0L;
        var result = 0L;

        for (int i = 0, j = 0; i < nums.Length; ++i)
        {
            sum += nums[i];

            while (sum * (i - j + 1) >= k)
            {
                sum -= nums[j++];
            }

            result += i - j + 1;
        }

        return result;
    }
}
