namespace leetcode_sharp;

// 1857. Largest Color Value in a Directed Graph
// https://leetcode.com/problems/largest-color-value-in-a-directed-graph/
public class S01857
{
    public int LargestPathValue(string colors, int[][] edges)
    {
        // Build the Graph and InDegree array
        var graph = new Dictionary<int, List<int>>();
        var n = colors.Length;
        var color = colors.ToCharArray();

        for (var i = 0; i < n; i++)
        {
            graph.Add(i, []);
        }

        var inDegree = new int[n];
        
        foreach (var edge in edges)
        {
            var u = edge[0];
            var v = edge[1];
            inDegree[v]++;
            graph[u].Add(v);
        }

        var dp = new int[n][];
        for (var i = 0; i < n; i++)
        {
            dp[i] = new int[26];
        }

        // Khans Algorithm (Iterative Topological Sort)
        var queue = new Queue<int>();
        for (var i = 0; i < n; i++)
        {
            if (inDegree[i] == 0)
            {
                queue.Enqueue(i);
                dp[i][color[i] - 'a'] = 1;
            }
        }

        var res = 0;
        var seen = 0;

        while (queue.Any())
        {
            var node = queue.Dequeue();
            seen++;

            var max = dp[node].Max();
            res = Math.Max(res, max);

            foreach (var nbr in graph[node])
            {
                // update the map of next node
                for (var i = 0; i < 26; i++)
                {
                    dp[nbr][i] = Math.Max(dp[nbr][i], dp[node][i] + (color[nbr] - 'a' == i ? 1 : 0));
                }

                inDegree[nbr]--;

                if (inDegree[nbr] == 0)
                {
                    queue.Enqueue(nbr);
                }
            }
        }

        return seen == n ? res : -1;
    }
}