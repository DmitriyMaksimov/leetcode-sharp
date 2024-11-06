using System.Numerics;

namespace leetcode_sharp;

// 3011. Find if Array Can Be Sorted
// https://leetcode.com/problems/find-if-array-can-be-sorted
public class S03011
{
    public bool CanSortArray(int[] nums)
    {
        var counts = nums.Select(num => BitOperations.PopCount((uint)num)).ToList();
        var n = nums.Length;
        var prevMax = int.MinValue;

        for (var i = 0; i < n;)
        {
            var end = i;
            var currMax = int.MinValue;
            var currMin = int.MaxValue;

            for (var j = i; j < n; j++)
            {
                if (counts[j] == counts[i])
                {
                    currMax = Math.Max(currMax, nums[j]);
                    currMin = Math.Min(currMin, nums[j]);
                    end++;
                }
                else
                {
                    break;
                }
            }

            i = end;

            if (currMin < prevMax)
            {
                return false;
            }

            prevMax = currMax;
        }

        return true;
    }
}
