namespace leetcode_sharp;

// 94. Binary Tree Inorder Traversal
// https://leetcode.com/problems/binary-tree-inorder-traversal/
public class S00094
{
    private readonly List<int> _result = new();

    public IList<int>? InorderTraversal(TreeNode? root)
    {
        inorderTraversal(root);
        return _result;
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