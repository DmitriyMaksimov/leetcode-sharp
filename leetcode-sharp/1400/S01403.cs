namespace leetcode_sharp;

// 1403. Minimum Subsequence in Non-Increasing Order
// https://leetcode.com/problems/minimum-subsequence-in-non-increasing-order/
public class S01403
{
    public IList<int> MinSubsequence(int[] nums)
    {
        Array.Sort(nums);

        var result = new List<int>();
        var sum = nums.Sum();
        var subSum = 0;
        
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            subSum += nums[i];
            result.Add(nums[i]);
            if (subSum > sum - subSum)
            {
                break;
            }
        }

        return result;
    }
}