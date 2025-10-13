namespace leetcode_sharp;

// 1637. Widest Vertical Area Between Two Points Containing No Points
// https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points
public class S01637
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        var xCoords = points.Select(p => p[0]).Order().ToArray();

        var res = 0;

        for (var i = 1; i < xCoords.Length; i++)
        {
            res = Math.Max(res, xCoords[i] - xCoords[i - 1]);
        }

        return res;
    }
}