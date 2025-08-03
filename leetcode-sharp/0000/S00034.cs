namespace leetcode_sharp;

// 34. Find First and Last Position of Element in Sorted Array
// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
public class S00034
{
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return [-1, -1];
        }

        var first = findFirst(nums, target);
        
        if (first >= nums.Length || nums[first] != target)
        {
            first = -1;
        }

        var last = findLast(nums, target);
        
        if (last >= nums.Length || nums[last] != target)
        {
            last = -1;
        }
        
        return [first, last];
    }
    
    private static int findFirst(IReadOnlyList<int> list, long key)
    {
        var low = 0;
        var high = list.Count - 1;

        while (low != high)
        {
            var mid = low + (high - low) / 2;
            long midVal = list[mid];

            if (midVal < key)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low;
    }
    
    private static int findLast(IReadOnlyList<int> list, long key)
    {
        var low = 0;
        var high = list.Count - 1;

        while (low != high)
        {
            var mid = low + (high - low + 1) / 2;
            long midVal = list[mid];

            if (midVal > key)
            {
                high = mid - 1;
            }
            else
            {
                low = mid;
            }
        }

        return low;
    }
}