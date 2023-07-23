namespace leetcode_sharp;

// 1498. Number of Subsequences That Satisfy the Given Sum Condition
// https://leetcode.com/problems/number-of-subsequences-that-satisfy-the-given-sum-condition/
public class S01498
{
    private const int Modulo = 1_000_000_007;
    
    public int NumSubseq(int[] nums, int target)
    {
        var powers = computePowers(nums.Length);

        Array.Sort(nums);

        var left = 0;
        var right = nums.Length - 1;
        var result = 0;

        while (left <= right)
        {
            if (nums[left] + nums[right] > target)
            {
                right--;
            }
            else
            {
                result = (result + powers[right - left++]) % Modulo;
            }
        }

        return result;
    }

    private static int[] computePowers(int n)
    {
        var result = new int[n];

        result[0] = 1;

        for (var i = 1; i < n; ++i)
        {
            result[i] = result[i - 1] * 2 % Modulo;
        }

        return result;
    }
}