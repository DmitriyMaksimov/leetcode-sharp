namespace leetcode_sharp;

// 1846. Maximum Element After Decreasing and Rearranging
// https://leetcode.com/problems/maximum-element-after-decreasing-and-rearranging
public class S01846
{
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        Array.Sort(arr);

        arr[0] = 1;

        for (var i = 1; i < arr.Length; ++i)
        {
            if (Math.Abs(arr[i] - arr[i - 1]) > 1)
            {
                arr[i] = arr[i - 1] + 1;
            }
        }

        return arr[^1];
    }
}