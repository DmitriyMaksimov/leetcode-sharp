namespace leetcode_sharp;

// 1779. Find Nearest Point That Has the Same X or Y Coordinate
// https://leetcode.com/problems/find-nearest-point-that-has-the-same-x-or-y-coordinate/
public class S01779
{
    public int NearestValidPoint(int x, int y, int[][] points)
    {
        var min = int.MaxValue;
        var index = -1;

        for (var i = 0; i < points.Length; i++)
        {
            var point = points[i];
            if (point[0] == x || point[1] == y)
            {
                var distance = Math.Abs(point[0] - x) + Math.Abs(point[1] - y);
                if (distance < min)
                {
                    min = distance;
                    index = i;
                }
            }
        }

        return index;
    }
}