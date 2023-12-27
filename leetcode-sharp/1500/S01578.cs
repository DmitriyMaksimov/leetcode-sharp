namespace leetcode_sharp;

// 1578. Minimum Time to Make Rope Colorful
// https://leetcode.com/problems/minimum-time-to-make-rope-colorful
public class S01578
{
    public int MinCost(string colors, int[] neededTime)
    {
        var result = 0;
        var maxCost = 0;
        var sumCost = 0;
        var n = colors.Length;

        for (var i = 0; i < n; ++i)
        {
            if (i > 0 && colors[i] != colors[i - 1])
            {
                result += sumCost - maxCost;
                sumCost = 0;
                maxCost = 0;
            }

            sumCost += neededTime[i];
            maxCost = Math.Max(maxCost, neededTime[i]);
        }

        result += sumCost - maxCost;

        return result;
    }
}