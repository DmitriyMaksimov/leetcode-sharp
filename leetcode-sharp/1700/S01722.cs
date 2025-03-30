namespace leetcode_sharp;

// 1722. Minimize Hamming Distance After Swap Operations
// https://leetcode.com/problems/minimize-hamming-distance-after-swap-operations
public class S01722
{
    public int MinimumHammingDistance(int[] source, int[] target, int[][] allowedSwaps)
    {
        var n = source.Length;
        var graph = new List<HashSet<int>>(new HashSet<int>[n]);

        for (var i = 0; i < n; i++)
        {
            graph[i] = [];
        }

        foreach (var edge in allowedSwaps)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        var visited = new bool[n];
        var res = n;

        for (var i = 0; i < n; i++)
        {
            if (visited[i])
            {
                continue;
            }

            List<int> found = [];
            Dfs(i, found, visited, graph);

            var count1 = found.GroupBy(j => source[j]).ToDictionary(g => g.Key, g => g.Count());
            var count2 = found.GroupBy(j => target[j]).ToDictionary(g => g.Key, g => g.Count());

            foreach (var key in count1.Keys)
            {
                if (count2.TryGetValue(key, out var value))
                {
                    res -= Math.Min(count1[key], value);
                }
            }
        }

        return res;
    }

    private static void Dfs(int i, List<int> found, bool[] visited, List<HashSet<int>> graph)
    {
        visited[i] = true;
        found.Add(i);

        foreach (var neighbor in graph[i].Where(neighbor => !visited[neighbor]))
        {
            Dfs(neighbor, found, visited, graph);
        }
    }
}
