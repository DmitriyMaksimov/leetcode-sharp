namespace leetcode_sharp;

// 1775. Equal Sum Arrays With Minimum Number of Operations
// https://leetcode.com/problems/equal-sum-arrays-with-minimum-number-of-operations
public class S01775
{
    public int MinOperations(int[] nums1, int[] nums2)
    {
        var sum1 = nums1.Sum();
        var sum2 = nums2.Sum();

        if (sum1 > sum2)
        {
            (nums1, nums2) = (nums2, nums1);
            (sum1, sum2) = (sum2, sum1);
        }

        var diff = sum2 - sum1;
        if (diff == 0)
        {
            return 0;
        }

        var result = 0;

        var arr = nums1.Select(x => 6 - x).ToList();
        arr.AddRange(nums2.Select(x => x - 1));

        arr.Sort((a, b) => b - a);

        foreach (var x in arr)
        {
            result++;
            diff -= x;
            if (diff <= 0)
            {
                return result;
            }
        }

        return -1;
    }
}
