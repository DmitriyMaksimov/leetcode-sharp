namespace leetcode_sharp;

// 2285. Maximum Total Importance of Roads
// https://leetcode.com/problems/maximum-total-importance-of-roads
public class S02285
{
    public long MaximumImportance(int n, int[][] roads)
    {
        var degree = new long[n];

        foreach (var road in roads)
        {
            degree[road[0]]++;
            degree[road[1]]++;
        }

        var x = 1L;
        return degree.Order().Sum(i => i * x++);
    }
}