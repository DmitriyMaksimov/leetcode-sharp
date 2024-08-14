namespace leetcode_sharp;

// 719. Find K-th Smallest Pair Distance
// https://leetcode.com/problems/find-k-th-smallest-pair-distance
public class S00719
{
    public int SmallestDistancePair(int[] nums, int k)
    {
        Array.Sort(nums);
        var n = nums.Length;
        var left = 0;
        var right = nums[n - 1] - nums[0];

        while (left < right)
        {
            var mid = (left + right) / 2;

            if (Helper(mid, nums, k))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    private static bool Helper(int mid, int[] nums, int k)
    {
        var total = 0;
        var j = 0;
        var n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            while (j < n && nums[j] - nums[i] <= mid)
            {
                j++;
            }

            j--;

            total += j - i;
        }

        return total >= k;
    }
}
