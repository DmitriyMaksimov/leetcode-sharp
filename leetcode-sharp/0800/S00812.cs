namespace leetcode_sharp;

// 812. Largest Triangle Area
// https://leetcode.com/problems/largest-triangle-area/
public class S00812
{
    public double LargestTriangleArea(int[][] points)
    {
        return (from i in points from j in points from k in points select 0.5 * Math.Abs(i[0] * j[1] + j[0] * k[1] + k[0] * i[1] - j[0] * i[1] - k[0] * j[1] - i[0] * k[1])).Max();
    }
}