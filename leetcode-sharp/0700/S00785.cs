namespace leetcode_sharp;

// 785. Is Graph Bipartite?
// https://leetcode.com/problems/is-graph-bipartite/
public class S00785
{
    private int[] _colors = null!;

    public bool IsBipartite(int[][] graph)
    {
        var n = graph.Length;
        _colors = new int[n];
        for (var i = 0; i < n; i++)
        {
            if (_colors[i] == 0 && !dfs(graph, i, 1))
            {
                return false;
            }
        }

        return true;
    }

    private bool dfs(int[][] graph, int i, int color)
    {
        _colors[i] = color;
        for (var j = 0; j < graph[i].Length; j++)
        {
            var adjacentNode = graph[i][j];
            if (_colors[adjacentNode] == -color)
            {
                continue;
            }

            if (_colors[adjacentNode] == color || !dfs(graph, adjacentNode, -color))
            {
                return false;
            }
        }

        return true;
    }
}