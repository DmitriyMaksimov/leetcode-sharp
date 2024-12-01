namespace leetcode_sharp;

// 3249. Count the Number of Good Nodes
// https://leetcode.com/problems/count-the-number-of-good-nodes
public class S03249
{
    private readonly List<List<int>> _graph = [];
    private int[] _subtreeSize = null!;

    public int CountGoodNodes(int[][] edges)
    {
        var n = edges.Length + 1;
        _subtreeSize = new int[n];

        for (var i = 0; i < n; i++)
        {
            _graph.Add([]);
        }

        foreach (var edge in edges)
        {
            _graph[edge[0]].Add(edge[1]);
            _graph[edge[1]].Add(edge[0]);
        }

        Dfs(0, -1);

        var result = 0;

        for (var i = 0; i < n; i++)
        {
            var isGoodNode = true;
            var previousSize = -1;

            foreach (int neighbor in _graph[i].Where(neighbor => _subtreeSize[neighbor] < _subtreeSize[i]))
            {
                if (previousSize == -1)
                {
                    previousSize = _subtreeSize[neighbor];
                }
                else if (previousSize != _subtreeSize[neighbor])
                {
                    isGoodNode = false;
                    break;
                }
            }

            if (isGoodNode)
            {
                result++;
            }
        }

        return result;
    }

    private int Dfs(int curr, int parent)
    {
        var size = 1 + _graph[curr].Where(neighbor => neighbor != parent).Sum(neighbor => Dfs(neighbor, curr));

        return _subtreeSize[curr] = size;
    }
}
