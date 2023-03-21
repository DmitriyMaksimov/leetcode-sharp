namespace leetcode_sharp;

// 540. Single Element in a Sorted Array
// https://leetcode.com/problems/single-element-in-a-sorted-array/
public class S00540
{
    public int SingleNonDuplicate(int[] nums)
    {
        var l = 0;
        var h = nums.Length - 1;
        
        while (l < h)
        {
            var mid = l + (h - l) / 2;

            if ((mid - l + 1) % 2 != 0)
            {
                // We want to have even number of elements on left side
                mid++;
            }

            if (nums[mid] == nums[mid - 1])
            {
                // Left half is ok => the single element on right half
                l = mid + 1;
            }
            else
            {
                // Left half is not ok => the single element on left half
                h = mid - 1;
            }
        }

        return nums[l];
    }
}