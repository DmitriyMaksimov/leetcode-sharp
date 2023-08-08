namespace leetcode_sharp;

// 105. Construct Binary Tree from Preorder and Inorder Traversal
// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
public class S00105
{
    private int _preorderIdx;
    private readonly Dictionary<int, int> _map = new();
    private int[] _preorder;

    public TreeNode? BuildTree(int[] preorder, int[] inorder)
    {
        _preorder = preorder;
        var len = inorder.Length;
        for (var i = 0; i < len; i++)
        {
            _map.Add(inorder[i], i);
        }

        return buildTree(0, len - 1);
    }

    private TreeNode? buildTree(int left, int right)
    {
        if (left > right)
        {
            return null;
        }

        var preorderValue = _preorder[_preorderIdx++];
        var inorderIndex = _map[preorderValue];

        return new TreeNode(preorderValue)
        {
            left = buildTree(left, inorderIndex - 1),
            right = buildTree(inorderIndex + 1, right)
        };
    }
}