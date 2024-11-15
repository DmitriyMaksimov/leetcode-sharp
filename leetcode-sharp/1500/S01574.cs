namespace leetcode_sharp;

// 1574. Shortest Subarray to be Removed to Make Array Sorted
// https://leetcode.com/problems/shortest-subarray-to-be-removed-to-make-array-sorted
public class S01574
{
    public int FindLengthOfShortestSubarray(int[] arr)
    {
        var n = arr.Length;
        var left = 0;
        var right = n - 1;

        while (left < n - 1 && arr[left] <= arr[left + 1])
        {
            left++;
        }

        if (left == n - 1)
        {
            return 0;
        }

        while (right > 0 && arr[right] >= arr[right - 1])
        {
            right--;
        }

        var result = Math.Min(n - left - 1, right);
        var i = 0;
        var j = right;

        while (i <= left && j < n)
        {
            if (arr[j] >= arr[i])
            {
                result = Math.Min(result, j - i - 1);
                i++;
            }
            else
            {
                j++;
            }
        }

        return result;
    }
}
