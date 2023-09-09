namespace leetcode_sharp;

// 1560. Most Visited Sector in a Circular Track
// https://leetcode.com/problems/most-visited-sector-in-a-circular-track/
public class S01560
{
    public IList<int> MostVisited(int n, int[] rounds)
    {
        var result = new List<int>();
        var start = rounds[0];
        var end = rounds[^1];

        if (start <= end)
        {
            for (var i = start; i <= end; i++)
            {
                result.Add(i);
            }
        }
        else
        {
            for (var i = 1; i <= end; i++)
            {
                result.Add(i);
            }

            for (var i = start; i <= n; i++)
            {
                result.Add(i);
            }
        }

        return result;
    }
}