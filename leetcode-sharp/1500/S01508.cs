namespace leetcode_sharp;

// 1508. Range Sum of Sorted Subarray Sums
// https://leetcode.com/problems/range-sum-of-sorted-subarray-sums
public class S01508
{
    public int RangeSum(int[] nums, int n, int left, int right)
    {
        const int mod = 1000000007;
        var prefixSums = new List<int>();

        for (var i = 0; i < n; i++)
        {
            var sum = 0;
            for (var j = i; j < n; j++)
            {
                sum += nums[j];
                prefixSums.Add(sum);
            }
        }

        var result = 0;
        prefixSums.Sort();

        for (var i = left - 1; i < right; i++)
        {
            result = (result + prefixSums[i]) % mod;
        }

        return result;
    }
}
