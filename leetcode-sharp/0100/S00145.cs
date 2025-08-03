namespace leetcode_sharp;

// 145. Binary Tree Postorder Traversal
// https://leetcode.com/problems/binary-tree-postorder-traversal/
public class S00145
{
    private readonly List<int> _result = [];

    public IList<int>? PostorderTraversal(TreeNode? root)
    {
        postorderTraversal(root);
        return _result;
    }
    
    private void postorderTraversal(TreeNode? node)
    {
        if (node == null)
        {
            return;
        }

        postorderTraversal(node.left);
        postorderTraversal(node.right);

        _result.Add(node.val);
    }
}