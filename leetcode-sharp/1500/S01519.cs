namespace leetcode_sharp;

// 1519. Number of Nodes in the Sub-Tree With the Same Label
// https://leetcode.com/problems/number-of-nodes-in-the-sub-tree-with-the-same-label/
public class S01519
{
    private readonly Dictionary<int, List<int>> _graph = new();
    private string _labels;
    private int[] _result;
    private Dictionary<int, int[]> _counts = new();

    public int[] CountSubTrees(int n, int[][] edges, string labels)
    {
        _labels = labels;
        _result = new int[n];

        foreach (var edge in edges)
        {
            _graph[edge[0]] = _graph.GetValueOrDefault(edge[0], new List<int>());
            _graph[edge[0]].Add(edge[1]);
            _graph[edge[1]] = _graph.GetValueOrDefault(edge[1], new List<int>());
            _graph[edge[1]].Add(edge[0]);
        }

        for (var i = 0; i < n; i++)
        {
            _counts.Add(i, new int[26]);
        }

        dfs(0, -1);

        return _result;
    }

    private void dfs(int node, int parentNode)
    {
        var myLabel = _labels[node];
        _counts[node][myLabel - 'a']++;

        foreach (var childNode in _graph[node])
        {
            if (childNode != parentNode)
            {
                dfs(childNode, node);
                for (var i = 0; i < 26; i++)
                {
                    _counts[node][i] += _counts[childNode][i];
                }
            }
        }

        _result[node] = _counts[node][myLabel - 'a'];
    }
}