namespace leetcode_sharp;

// 2246. Longest Path With Different Adjacent Characters
// https://leetcode.com/problems/longest-path-with-different-adjacent-characters/
public class S02246
{
    private IList<IList<int>> _children = new List<IList<int>>();
    private int _result = 0;

    public int LongestPath(int[] parent, string s)
    {
        buildTree(parent);

        dfs(s, 0);

        return _result;
    }

    private int dfs(string s, int i)
    {
        var queue = new PriorityQueue<int, int>();

        foreach (var j in _children[i])
        {
            var maxPath = dfs(s, j);
            if (s[j] != s[i])
            {
                queue.Enqueue(maxPath, -maxPath);
            }
        }

        var maxPath1 = queue.Count == 0 ? 0: queue.Dequeue();
        var maxPath2 = queue.Count == 0 ? 0: queue.Dequeue();

        _result = Math.Max(_result, maxPath1 + maxPath2 + 1);

        return maxPath1 + 1;
    }

    private void buildTree(int[] parent)
    {
        for (var i = 0; i < parent.Length; i++)
        {
            _children.Add(new List<int>());
        }

        for (var i = 1; i < parent.Length; i++)
        {
            _children[parent[i]].Add(i);
        }
    }
}