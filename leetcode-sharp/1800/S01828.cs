namespace leetcode_sharp;

// 1828. Queries on Number of Points Inside a Circle
// https://leetcode.com/problems/queries-on-number-of-points-inside-a-circle
public class S01828
{
    public int[] CountPoints(int[][] points, int[][] queries)
    {
        var countPoints = new int[queries.Length];

        foreach (var point in points)
        {
            for (var j = 0; j < queries.Length; j++)
            {
                if (Math.Sqrt((point[0] - queries[j][0]) * (point[0] - queries[j][0]) + (point[1] - queries[j][1]) * (point[1] - queries[j][1])) <= queries[j][2])
                {
                    ++countPoints[j];
                }
            }
        }

        return countPoints;
    }
}