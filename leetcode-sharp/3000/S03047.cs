namespace leetcode_sharp;

// 3047. Find the Largest Area of Square Inside Two Rectangles
// https://leetcode.com/problems/find-the-largest-area-of-square-inside-two-rectangles
public class S03047
{
    public long LargestSquareArea(int[][] bottomLeft, int[][] topRight)
    {
        var n = bottomLeft.Length;
        var maxArea = 0L;

        for (var i = 0; i < n; ++i)
        {
            var ax1 = bottomLeft[i][0];
            var ay1 = bottomLeft[i][1];
            var ax2 = topRight[i][0];
            var ay2 = topRight[i][1];

            for (var j = i + 1; j < n; ++j)
            {
                var bx1 = bottomLeft[j][0];
                var by1 = bottomLeft[j][1];
                var bx2 = topRight[j][0];
                var by2 = topRight[j][1];

                var overlapWidth = Math.Min(ax2, bx2) - Math.Max(ax1, bx1);
                var overlapHeight = Math.Min(ay2, by2) - Math.Max(ay1, by1);

                if (overlapWidth > 0 && overlapHeight > 0)
                {
                    var side = Math.Min(overlapWidth, overlapHeight);
                    var area = (long)side * side;

                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
        }

        return maxArea;
    }
}