namespace leetcode_sharp;

// 3904. Smallest Stable Index II
// https://leetcode.com/problems/smallest-stable-index-ii
public class S03904
{
    public int FirstStableIndex(int[] nums, int k)
    {
        var n = nums.Length;
        var minI = new int[n];

        var minT = int.MaxValue;
        for (var i = n - 1; i >= 0; i--)
        {
            if (nums[i] < minT)
            {
                minT = nums[i];
            }

            minI[i] = minT;
        }

        var maxT = 0;
        for (var i = 0; i < n; i++)
        {
            if (nums[i] > maxT)
            {
                maxT = nums[i];
            }

            if (maxT - minI[i] <= k)
            {
                return i;
            }
        }

        return -1;
    }
}