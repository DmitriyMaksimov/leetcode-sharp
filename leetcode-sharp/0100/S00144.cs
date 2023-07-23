namespace leetcode_sharp;

// 144. Binary Tree Preorder Traversal
// https://leetcode.com/problems/binary-tree-preorder-traversal/
public class S00144
{
    private readonly List<int> _result = new();

    public IList<int>? PreorderTraversal(TreeNode? root)
    {
        preorderTraversal(root);
        
        return _result;
    }

    private void preorderTraversal(TreeNode? node)
    {
        if (node == null)
        {
            return;
        }
        
        _result.Add(node.val);
        
        preorderTraversal(node.left);
        preorderTraversal(node.right);
    }
}