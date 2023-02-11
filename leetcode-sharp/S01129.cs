namespace leetcode_sharp;

// 1129. Shortest Path with Alternating Colors
// https://leetcode.com/problems/shortest-path-with-alternating-colors/
public class S01129
{
    private readonly Dictionary<int, List<(int node, int color)>> _graph = new();
    private readonly HashSet<(int node, int color)> _visited = new();

    public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
    {
        const int red = 0;
        const int blue = 1;

        foreach (var edge in redEdges)
        {
            _graph[edge[0]] = _graph.GetValueOrDefault(edge[0], new List<(int node, int color)>());
            _graph[edge[0]].Add((edge[1], red));
        }

        foreach (var edge in blueEdges)
        {
            _graph[edge[0]] = _graph.GetValueOrDefault(edge[0], new List<(int node, int color)>());
            _graph[edge[0]].Add((edge[1], blue));
        }

        var queue = new Queue<(int node, int steps, int color)>();

        var result = new int[n];
        Array.Fill(result, -1);

        _visited.Add((0, red));
        _visited.Add((0, blue));
        result[0] = 0;

        queue.Enqueue((0, 0, -1));

        while (queue.Any())
        {
            var (node, steps, prevColor) = queue.Dequeue();

            if (!_graph.ContainsKey(node))
            {
                continue;
            }

            foreach (var (neighbor, color) in _graph[node])
            {
                if (_visited.Contains((neighbor, color)) || color == prevColor) continue;

                if (result[neighbor] == -1)
                {
                    // Not set yet => set it - it will be shortest path
                    result[neighbor] = steps + 1;
                }
                    
                _visited.Add((neighbor, color));
                queue.Enqueue((neighbor, steps + 1, color));
            }
        }

        return result;
    }
}