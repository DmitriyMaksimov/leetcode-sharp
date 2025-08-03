namespace leetcode_sharp;

// 863. All Nodes Distance K in Binary Tree
// https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree/
public class S00863
{
    private readonly Dictionary<TreeNode, TreeNode?> _parentMap = new();
    private readonly HashSet<TreeNode?> _visited = [];

    public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
    {
        dfs(root, null);
        return findNodes(target, k);
    }

    private void dfs(TreeNode? node, TreeNode? parent)
    {
        if (node == null) return;

        _parentMap[node] = parent;
        dfs(node.left, node);
        dfs(node.right, node);
    }

    private List<int> findNodes(TreeNode? origin, int distance)
    {
        if (origin == null)
        {
            return [];
        }

        if (_visited.Contains(origin)) return [];

        if (distance == 0)
        {
            return [origin.val];
        }

        _visited.Add(origin);

        var res1 = findNodes(origin.left, distance - 1);
        var res2 = findNodes(origin.right, distance - 1);
        var res3 = findNodes(_parentMap[origin], distance - 1);

        return res1.Concat(res2).Concat(res3).ToList();
    }
}