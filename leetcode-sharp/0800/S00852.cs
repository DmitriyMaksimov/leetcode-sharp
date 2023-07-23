namespace leetcode_sharp;

// 852. Peak Index in a Mountain Array
// https://leetcode.com/problems/peak-index-in-a-mountain-array/
public class S00852
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        var left = 0;
        var right = arr.Length - 1;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (arr[mid] > arr[mid + 1])
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