namespace leetcode_sharp;

// 162. Find Peak Element
// https://leetcode.com/problems/find-peak-element/
public class S00162
{
    public int FindPeakElement(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] > nums[mid + 1])
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
}