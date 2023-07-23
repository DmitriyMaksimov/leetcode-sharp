namespace UnitTests;

// 154. Find Minimum in Rotated Sorted Array II
// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array-ii/
public class S00154
{
    public int FindMin(int[] nums)
    {
        return nums[findRotationIndex(nums)];
    }
    
    // Binary search to find the index of the smallest value (which is the rotation index)
    private static int findRotationIndex(IReadOnlyList<int> nums)
    {
        var lo = 0;
        var hi = nums.Count - 1;

        while (lo < hi)
        {
            var mid = lo + (hi - lo) / 2;

            if (nums[mid] > nums[hi])
            {
                lo = mid + 1;
            }
            else if (nums[mid] < nums[lo])
            { 
                hi = mid;
                lo++;
            }
            else
            {
                // nums[lo] <= nums[mid] <= nums[hi] 
                hi--;
            }
        }

        return lo;
    }
}