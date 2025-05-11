namespace leetcode_sharp;

// 2918. Minimum Equal Sum of Two Arrays After Replacing Zeros
// https://leetcode.com/problems/minimum-equal-sum-of-two-arrays-after-replacing-zeros
public class S02918
{
    public long MinSum(int[] nums1, int[] nums2)
    {
        var numberOfZeros1 = nums1.Count(x => x == 0);
        var numberOfZeros2 = nums2.Count(x => x == 0);

        var minSum1 = nums1.Select(x => (long)x).Sum() + numberOfZeros1;
        var minSum2 = nums2.Select(x => (long)x).Sum() + numberOfZeros2;

        if ((minSum1 < minSum2 && numberOfZeros1 == 0) || (minSum2 < minSum1 && numberOfZeros2 == 0))
        {
            return -1;
        }

        return Math.Max(minSum1, minSum2);
    }
}
