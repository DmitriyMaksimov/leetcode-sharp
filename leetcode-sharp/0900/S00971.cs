namespace leetcode_sharp;

// 971. Flip Binary Tree To Match Preorder Traversal
// https://leetcode.com/problems/flip-binary-tree-to-match-preorder-traversal
public class S00971
{
    private readonly List<int> _result = [];
    private int _counter;

    public IList<int> FlipMatchVoyage(TreeNode? root, int[] voyage)
    {
        return Dfs(root, voyage) ? _result : [-1];
    }

    private bool Dfs(TreeNode? node, int[] v)
    {
        if (node == null)
        {
            return true;
        }

        if (node.val != v[_counter++])
        {
            return false;
        }

        if (node.left != null && node.left.val != v[_counter])
        {
            _result.Add(node.val);
            return Dfs(node.right, v) && Dfs(node.left, v);
        }

        return Dfs(node.left, v) && Dfs(node.right, v);
    }
}
