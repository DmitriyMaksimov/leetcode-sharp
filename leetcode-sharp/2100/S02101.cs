namespace leetcode_sharp;

// 2101. Detonate the Maximum Bombs
// https://leetcode.com/problems/detonate-the-maximum-bombs/
public class S02101
{
    public int MaximumDetonation(int[][] bombs)
    {
        var n = bombs.Length;
        var gr = new List<List<int>>(n);
        for (var i = 0; i < n; i++)
        {
            gr.Add([]);
            for (var j = 0; j < n; j++)
            {
                if (i != j)
                {
                    long x1 = bombs[i][0];
                    long y1 = bombs[i][1];
                    long r1 = bombs[i][2];

                    long x = bombs[j][0];
                    long y = bombs[j][1];
                    
                    var distanceSq = (x - x1) * (x - x1) + (y - y1) * (y - y1);
                    if (distanceSq <= r1 * r1)
                    {
                        gr[i].Add(j);
                    }
                }
            }
        }

        var ans = int.MinValue;

        for (var i = 0; i < n; i++)
        {
            var count = 0;
            var visited = new bool[n];
            dfs(gr, visited, ref count, i);
            ans = Math.Max(ans, count);
        }

        return ans;
    }

    private void dfs(IReadOnlyList<List<int>> gr, IList<bool> visited, ref int count, int i)
    {
        visited[i] = true;
        count++;
        foreach (var j in gr[i].Where(j => !visited[j]))
        {
            dfs(gr, visited, ref count, j);
        }
    }
}