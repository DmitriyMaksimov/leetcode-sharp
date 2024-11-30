namespace leetcode_sharp;

// 2097. Valid Arrangement of Pairs
// https://leetcode.com/problems/valid-arrangement-of-pairs
public class S02097
{
    public int[][] ValidArrangement(int[][] pairs)
    {
        var graph = new Dictionary<int, Stack<int>>();
        var inDegree = new Dictionary<int, int>();
        var outDegree = new Dictionary<int, int>();

        foreach (var pair in pairs)
        {
            var u = pair[0];
            var v = pair[1];

            graph.TryAdd(u, []);
            graph[u].Push(v);

            outDegree.TryAdd(u, 0);
            inDegree.TryAdd(v, 0);

            outDegree[u]++;
            inDegree[v]++;
        }

        var startNode = pairs[0][0];
        foreach (var node in outDegree.Keys)
        {
            if (outDegree[node] - inDegree.GetValueOrDefault(node) == 1)
            {
                startNode = node;
                break;
            }
        }

        var route = new List<int>();
        var stack = new Stack<int>();
        stack.Push(startNode);

        while (stack.Count > 0)
        {
            while (graph.ContainsKey(stack.Peek()) && graph[stack.Peek()].Count > 0)
            {
                stack.Push(graph[stack.Peek()].Pop());
            }

            route.Add(stack.Pop());
        }

        route.Reverse();

        var result = new List<int[]>();

        for (var i = 0; i < route.Count - 1; i++)
        {
            result.Add([route[i], route[i + 1]]);
        }

        return result.ToArray();
    }
}
