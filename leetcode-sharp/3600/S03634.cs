namespace leetcode_sharp;

// 3634. Minimum Removals to Balance Array
// https://leetcode.com/problems/minimum-removals-to-balance-array
public class S03634
{
    public int MinRemoval(int[] nums, int k)
    {
        Array.Sort(nums);
        var n = nums.Length;

        var maxKeep = 0;

        for (var i = 0; i < n; i++)
        {
            long minVal = nums[i];
            var maxAllowed = minVal * k;

            var left = i;
            var right = n;

            while (left < right)
            {
                var mid = left + (right - left) / 2;
            
                if (nums[mid] <= maxAllowed)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            var keepCount = left - i;

            if (keepCount > maxKeep)
            {
                maxKeep = keepCount;
            }
        }

        return n - maxKeep;
    }
}