namespace leetcode_sharp;

// 3373. Maximize the Number of Target Nodes After Connecting Trees II
// https://leetcode.com/problems/maximize-the-number-of-target-nodes-after-connecting-trees-ii
public class S03373
{
    private readonly Dictionary<int, List<int>> _tree1 = new();
    private readonly Dictionary<int, List<int>> _tree2 = new();
    private readonly int[] _color1 = new int[2];
    private readonly int[] _color2 = new int[2];
    private int[] _nodeColor1 = null!;
    private int[] _nodeColor2 = null!;

    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2)
    {
        var n = edges1.Length + 1;
        var m = edges2.Length + 1;
        _nodeColor1 = new int[n];
        _nodeColor2 = new int[m];

        Build(edges1, _tree1);
        Build(edges2, _tree2);
        Bfs(_tree1, _color1, _nodeColor1);
        Bfs(_tree2, _color2, _nodeColor2);

        var arr = new int[n];
        var max = Math.Max(_color2[0], _color2[1]);

        for (var i = 0; i < n; i++)
        {
            arr[i] = _color1[_nodeColor1[i]] + max;
        }

        return arr;
    }

    private static void Build(int[][] edges, Dictionary<int, List<int>> map)
    {
        for (var i = 0; i < edges.Length + 1; i++)
        {
            map[i] = [];
        }

        foreach (var e in edges)
        {
            map[e[0]].Add(e[1]);
            map[e[1]].Add(e[0]);
        }
    }

    private static void Bfs(Dictionary<int, List<int>> map, int[] color, int[] col)
    {
        var n = map.Count;
        var q = new Queue<int[]>();
        var visited = new bool[n];
        q.Enqueue([0, 0]);

        while (q.Count > 0)
        {
            var top = q.Dequeue();
            var node = top[0];
            var c = top[1];

            visited[node] = true;
            col[node] = c;
            color[c]++;

            foreach (int adj in map[node].Where(adj => !visited[adj]))
            {
                q.Enqueue([adj, (c + 1) % 2]);
            }
        }
    }
}
