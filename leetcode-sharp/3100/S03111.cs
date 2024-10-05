namespace leetcode_sharp;

// 3111. Minimum Rectangles to Cover Points
// https://leetcode.com/problems/minimum-rectangles-to-cover-points/
public class S03111
{
    public int MinRectanglesToCoverPoints(int[][] points, int w)
    {
        Array.Sort(points, (a, b) => a[0] - b[0]);

        var result = 0;
        var last = -1;

        foreach (var point in points)
        {
            if (point[0] <= last) continue;

            result++;
            last = point[0] + w;
        }

        return result;
    }
}
