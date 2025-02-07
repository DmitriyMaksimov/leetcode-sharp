namespace leetcode_sharp;

// 3160. Find the Number of Distinct Colors Among the Balls
// https://leetcode.com/problems/find-the-number-of-distinct-colors-among-the-balls
public class S03160
{
    public int[] QueryResults(int limit, int[][] queries)
    {
        var ballToColor = new Dictionary<int, int>();
        var colorCounts = new Dictionary<int, int>();
        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var ball = queries[i][0];
            var colorTo = queries[i][1];

            if (ballToColor.TryGetValue(ball, out var value))
            {
                if (colorCounts[value] == 1)
                {
                    colorCounts.Remove(value);
                }
                else
                {
                    colorCounts[value]--;
                }

                ballToColor.Remove(ball);
            }

            ballToColor[ball] = colorTo;
            colorCounts[colorTo] = colorCounts.GetValueOrDefault(colorTo) + 1;

            result[i] = colorCounts.Count;
        }

        return result;
    }
}
