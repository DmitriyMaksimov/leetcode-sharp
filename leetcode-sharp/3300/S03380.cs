namespace leetcode_sharp;

// 3380. Maximum Area Rectangle With Point Constraints I
// https://leetcode.com/problems/maximum-area-rectangle-with-point-constraints-i
public class S03380
{
    public int MaxRectangleArea(int[][] points)
    {
        var pointSet = new HashSet<string>();
        var n = points.Length;

        for (var i = 0; i < n; i++)
        {
            pointSet.Add(points[i][0] + "," + points[i][1]);
        }

        var maxArea = -1L;

        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                var x1 = points[i][0];
                var y1 = points[i][1];
                var x2 = points[j][0];
                var y2 = points[j][1];

                if (x1 != x2 && y1 != y2)
                {
                    if (pointSet.Contains(x1 + "," + y2) && pointSet.Contains(x2 + "," + y1))
                    {
                        var area = (long)Math.Abs(x2 - x1) * Math.Abs(y2 - y1);

                        var validRectangle = true;
                        for (var k = 0; k < n; k++)
                        {
                            var x = points[k][0];
                            var y = points[k][1];

                            if ((x == x1 || x == x2) && (y == y1 || y == y2))
                            {
                                continue;
                            }

                            if (x > Math.Min(x1, x2) && x < Math.Max(x1, x2) && y > Math.Min(y1, y2) && y < Math.Max(y1, y2))
                            {
                                validRectangle = false;
                                break;
                            }

                            if ((x == x1 || x == x2) && (y >= Math.Min(y1, y2) && y <= Math.Max(y1, y2)))
                            {
                                validRectangle = false;
                                break;
                            }

                            if ((y == y1 || y == y2) && (x >= Math.Min(x1, x2) && x <= Math.Max(x1, x2)))
                            {
                                validRectangle = false;
                                break;
                            }
                        }

                        if (validRectangle)
                        {
                            maxArea = Math.Max(maxArea, area);
                        }
                    }
                }
            }
        }

        return (int)maxArea;
    }
}
