namespace leetcode_sharp;

// 2467. Most Profitable Path in a Tree
// https://leetcode.com/problems/most-profitable-path-in-a-tree
public class S02467
{
    private bool[] _visited = null!;
    private List<int>[] _graph = null!;
    private int _bob;
    private int[] _amount = null!;
    private int _n;

    public int MostProfitablePath(int[][] edges, int bob, int[] amount)
    {
        _n = edges.Length + 1;
        _bob = bob;
        _amount = amount;
        _visited = new bool[_n];
        _graph = new List<int>[_n];
        for (var i = 0; i < _n; i++)
        {
            _graph[i] = [];
        }

        foreach (var edge in edges)
        {
            _graph[edge[0]].Add(edge[1]);
            _graph[edge[1]].Add(edge[0]);
        }

        return Dfs(0, 0).result;
    }

    private (int result, int distance) Dfs(int i, int distanceFromZero)
    {
        _visited[i] = true;
        var res = int.MinValue;
        var distanceToBob = i == _bob ? 0 : _n;

        foreach (var j in _graph[i].Where(j => !_visited[j]))
        {
            var (cur, kk) = Dfs(j, distanceFromZero + 1);
            res = Math.Max(res, cur);
            distanceToBob = Math.Min(distanceToBob, kk);
        }

        if (res == int.MinValue)
        {
            res = 0;
        }

        if (distanceFromZero == distanceToBob)
        {
            res += _amount[i] / 2;
        }

        if (distanceFromZero < distanceToBob)
        {
            res += _amount[i];
        }

        return (res, distanceToBob + 1);
    }
}
