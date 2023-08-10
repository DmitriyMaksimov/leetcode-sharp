namespace leetcode_sharp;

// 81. Search in Rotated Sorted Array II
// https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
public class S00081
{
    public bool Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                return true;
            }

            if (nums[mid] == nums[left] && nums[mid] == nums[right])
            {
                left++;
                right--;
            }
            else if (nums[mid] >= nums[left])
            {
                if (target >= nums[left] && target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else if (nums[mid] <= nums[right])
            {
                if (target > nums[mid] && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }

        return false;
    }
}