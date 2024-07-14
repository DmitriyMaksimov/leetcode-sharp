namespace leetcode_sharp;

// 3194. Minimum Average of Smallest and Largest Elements
// https://leetcode.com/problems/minimum-average-of-smallest-and-largest-elements
public class S03194
{
    public double MinimumAverage(int[] nums)
    {
        Array.Sort(nums);

        var n = nums.Length;
        var result = double.MaxValue;

        for (var i = 0; i < n / 2; i++)
        {
            var average = (nums[i] + nums[n - i - 1]) / 2.0;
            result = Math.Min(result, average);
        }
        
        return result;
    }
}