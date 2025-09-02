namespace leetcode_sharp;

// 3025. Find the Number of Ways to Place People I
// https://leetcode.com/problems/find-the-number-of-ways-to-place-people-i
public class S03025
{
    public int NumberOfPairs(int[][] points)
    {
        Array.Sort(points, (p, q) => p[0] == q[0] ? p[1].CompareTo(q[1]) : q[0].CompareTo(p[0]));

        var n = points.Length;
        var result = 0;

        for (var i = 0; i < n - 1; i++)
        {
            var minY = int.MaxValue;
            var yi = points[i][1];

            for (var j = i + 1; j < n; j++)
            {
                var yj = points[j][1];

                if (yj >= yi && minY > yj)
                {
                    result++;
                    minY = yj;
                }
            }
        }

        return result;
    }
}