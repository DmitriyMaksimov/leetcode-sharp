namespace leetcode_sharp;

// 42. Trapping Rain Water
// https://leetcode.com/problems/trapping-rain-water/
public class S00042
{
    public int Trap(int[] height)
    {
        var n = height.Length;
        var leftMax = new int[n];
        var rightMax = new int[n];

        for (var i = 1; i < n; ++i)
        {
            leftMax[i] = Math.Max(height[i - 1], leftMax[i - 1]);
        }

        for (var i = n - 2; i >= 0; --i)
        {
            rightMax[i] = Math.Max(height[i + 1], rightMax[i + 1]);
        }

        var answer = 0;

        for (var i = 0; i < n; ++i)
        {
            var waterLevel = Math.Min(leftMax[i], rightMax[i]);
            if (waterLevel >= height[i])
            {
                answer += waterLevel - height[i];
            }
        }

        return answer;
    }
}