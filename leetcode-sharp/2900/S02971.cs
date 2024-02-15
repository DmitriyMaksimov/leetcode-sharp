namespace leetcode_sharp;

// 2971. Find Polygon With the Largest Perimeter
// https://leetcode.com/problems/find-polygon-with-the-largest-perimeter
public class S02971
{
    public long LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        var len = nums.Length;
        var arr = new long[len];
        arr[0] = nums[0];

        for (var i = 1; i < len; i++)
        {
            arr[i] += arr[i - 1] + nums[i];
        }

        long ans = int.MinValue;

        for (var i = 2; i < len; i++)
        {
            if (arr[i] - arr[i - 1] < arr[i - 1])
            {
                ans = Math.Max(ans, arr[i]);
            }
        }

        return ans == int.MinValue ? -1 : ans;
    }
}