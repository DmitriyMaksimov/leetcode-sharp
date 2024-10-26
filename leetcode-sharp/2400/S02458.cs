namespace leetcode_sharp;

// 2458. Height of Binary Tree After Subtree Removal Queries
// https://leetcode.com/problems/height-of-binary-tree-after-subtree-removal-queries
public class S02458
{
    private readonly Dictionary<int, int> _cache = [];
    private readonly Dictionary<int, int> _answers = [];

    public int[] TreeQueries(TreeNode? root, int[] queries)
    {
        Dfs(root, 0, 0);

        return queries.Select(query => _answers[query]).ToArray();
    }

    private int Height(TreeNode? node)
    {
        if (node == null)
        {
            return 0;
        }

        if (_cache.TryGetValue(node.val, out var value))
        {
            return value;
        }

        return _cache[node.val] = Math.Max(Height(node.left), Height(node.right)) + 1;
    }

    private void Dfs(TreeNode? node, int depth, int maxDepth)
    {
        if (node == null)
        {
            return;
        }

        _answers[node.val] = maxDepth;
        Dfs(node.left, depth + 1, Math.Max(maxDepth, depth + Height(node.right)));
        Dfs(node.right, depth + 1, Math.Max(maxDepth, depth + Height(node.left)));
    }
}
