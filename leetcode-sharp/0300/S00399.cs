namespace leetcode_sharp;

// 399. Evaluate Division
// https://leetcode.com/problems/evaluate-division/
public class S00399
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        var graph = buildGraph(equations, values);
        var result = new double[queries.Count];

        for (var i = 0; i < queries.Count; i++)
        {
            result[i] = getPathWeight(queries[i][0], queries[i][1], new HashSet<string>(), graph);
        }

        return result;
    }

    private static double getPathWeight(string start, string end, ISet<string> visited, IReadOnlyDictionary<string, Dictionary<string, double>> graph)
    {
        if (!graph.ContainsKey(start))
        {
            // No start node => can't calculate 
            return -1.0;
        }

        if (graph[start].ContainsKey(end))
        {
            // Direct connection
            return graph[start][end];
        }

        visited.Add(start);

        foreach (var neighbour in graph[start])
        {
            if (!visited.Contains(neighbour.Key))
            {
                var productWeight = getPathWeight(neighbour.Key, end, visited, graph);
                if (productWeight != -1.0)
                {
                    return neighbour.Value * productWeight;
                }
            }
        }

        return -1.0;
    }

    private static Dictionary<string, Dictionary<string, double>> buildGraph(IList<IList<string>> equations, IReadOnlyList<double> values)
    {
        var graph = new Dictionary<string, Dictionary<string, double>>();

        for (var i = 0; i < equations.Count; i++)
        {
            var u = equations[i][0];
            var v = equations[i][1];

            graph[u] = graph.GetValueOrDefault(u, new Dictionary<string, double>());
            graph[u].Add(v, values[i]);
            
            graph[v] = graph.GetValueOrDefault(v, new Dictionary<string, double>());
            graph[v].Add(u, 1 / values[i]);
        }

        return graph;
    }
}