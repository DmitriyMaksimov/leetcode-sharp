namespace leetcode_sharp;

// 11. Container With Most Water
// https://leetcode.com/problems/container-with-most-water/
public class S00011
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var result = 0;

        while (left < right)
        {
            var currentArea = Math.Min(height[left], height[right]) * (right - left);
            result = Math.Max(result, currentArea);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return result;
    }
}