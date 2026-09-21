namespace leetcode_sharp;

// 3528. Unit Conversion I
// https://leetcode.com/problems/unit-conversion-i
public class S03428
{
    private const int Mod = 1_000_000_007;

    public int[] BaseUnitConversions(int[][] conversions)
    {
        var n = conversions.Length + 1;

        List<List<(int target, int factor)>> graph = [];
        for (var i = 0; i < n; i++)
        {
            graph.Add([]);
        }

        foreach (var conversion in conversions)
        {
            var src = conversion[0];
            var tgt = conversion[1];
            var factor = conversion[2];
            graph[src].Add((tgt, factor));
        }

        var result = new int[n];
        result[0] = 1;

        Dfs(0, graph, result);

        return result;
    }

    private void Dfs(int baseUnit, List<List<(int target, int factor)>> graph, int[] result)
    {
        foreach (var (v, factor) in graph[baseUnit])
        {
            result[v] = (int)((long)result[baseUnit] * factor % Mod);
            Dfs(v, graph, result);
        }
    }
}
