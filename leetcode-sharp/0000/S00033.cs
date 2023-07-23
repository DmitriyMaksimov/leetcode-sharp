namespace leetcode_sharp;

// 33. Search in Rotated Sorted Array
// https://leetcode.com/problems/search-in-rotated-sorted-array/
public class S00033
{
    public int Search(int[] nums, int target)
    {
        var rotationIndex = findRotationIndex(nums);
        var n = nums.Length;
        var lo = 0;
        var hi = n - 1;
        
        // Binary search with a twist for rotation
        while (lo <= hi)
        {
            var mid = lo + (hi - lo) / 2;
            var arrayMid = (mid + rotationIndex) % n;
            
            if (nums[arrayMid] == target)
            {
                return arrayMid;
            }

            if (nums[arrayMid] < target)
            {
                lo = mid + 1;
            }
            else
            {
                hi = mid - 1;
            }
        }

        return -1;
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
            else
            {
                hi = mid;
            }
        }

        return lo;
    }
}