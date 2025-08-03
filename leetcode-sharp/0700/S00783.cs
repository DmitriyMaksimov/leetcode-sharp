namespace leetcode_sharp;

// 783. Minimum Distance Between BST Nodes
// https://leetcode.com/problems/minimum-distance-between-bst-nodes/
public class S00783
{
    private readonly List<int> _result = [];

    public int MinDiffInBST(TreeNode? root)
    {
        inorderTraversal(root);
        var diff = int.MaxValue;
        for (var i = 0; i < _result.Count - 1; i++)
        {
            diff = Math.Min(diff, Math.Abs(_result[i] - _result[i + 1]));
        }

        return diff;
    }

    private void inorderTraversal(TreeNode? node)
    {
        if (node == null)
        {
            return;
        }

        inorderTraversal(node.left);
        _result.Add(node.val);
        inorderTraversal(node.right);
    }
}