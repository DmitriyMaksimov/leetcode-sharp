namespace leetcode_sharp;

// 2049. Count Nodes With the Highest Score
// https://leetcode.com/problems/count-nodes-with-the-highest-score
public class S02049
{
    public int CountHighestScoreNodes(int[] parents)
    {
        var n = parents.Length;
        List<List<int>> adjList = [];

        for (var i = 0; i < n; i++)
        {
            adjList.Add([]);
        }

        var scores = new long[n];

        for (var i = 1; i < n; i++)
        {
            adjList[parents[i]].Add(i);
        }

        Dfs(adjList, scores, 0);

        var maxVal = scores.Max();

        return scores.Count(v => v == maxVal);
    }

    private static long Dfs(List<List<int>> adjList, long[] scores, int i)
    {
        var prod = 1L;
        var sum = 1L;

        foreach (long cnt in adjList[i].Select(j => Dfs(adjList, scores, j)))
        {
            prod *= cnt;
            sum += cnt;
        }

        scores[i] = prod * Math.Max(1, adjList.Count - sum);

        return sum;
    }
}
