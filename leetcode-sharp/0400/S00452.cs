namespace leetcode_sharp;

// 452. Minimum Number of Arrows to Burst Balloons
// https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons/
public class S00452
{
    public int FindMinArrowShots(int[][] points)
    {
        if (points.Length == 0)
        {
            return 0;
        }

        if (points.Length == 1)
        {
            return 1;
        }

        var count = 0;
        var minEnd = long.MinValue;

        var orderedPoints = points.OrderBy(x => x[0]);

        foreach (var point in orderedPoints)
        {
            if (point[0] > minEnd)
            {
                count++;
                minEnd = point[1];
            }
            else
            {
                minEnd = Math.Min(minEnd, point[1]);
            }
        }

        return count;
    }
}