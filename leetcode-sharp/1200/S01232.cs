namespace leetcode_sharp;

// 1232. Check If It Is a Straight Line
// https://leetcode.com/problems/check-if-it-is-a-straight-line/
public class S01232
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        var n = coordinates.Length;
        var x1 = coordinates[0][0];
        var y1 = coordinates[0][1];
        var x2 = coordinates[1][0];
        var y2 = coordinates[1][1];

        for (var i = 2; i < n; ++i)
        {
            var x = coordinates[i][0];
            var y = coordinates[i][1];

            if ((y - y1) * (x - x2) != (y - y2) * (x - x1))
            {
                return false;
            }
        }

        return true;
    }
}