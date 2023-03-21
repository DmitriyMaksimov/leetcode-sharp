namespace leetcode_sharp;

// 106. Construct Binary Tree from Inorder and Postorder Traversal
// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
public class S00106
{
    public TreeNode? BuildTree(int[] inorder, int[] postorder)
    {
        var n = inorder.Length;

        var inorderMap = new Dictionary<int, int>();
        for (var i = 0; i < n; i++)
        {
            inorderMap[inorder[i]] = i;
        }

        // Last element in postorder sequence is root
        var pIndex = n - 1;

        return construct(0, n - 1, postorder, ref pIndex, inorderMap);
    }

    private static TreeNode? construct(int start, int end, int[] postorder, ref int refIndex, IReadOnlyDictionary<int, int> inorderMap)
    {
        if (start > end)
        {
            return null;
        }

        // This value would be the root TreeNode of a subtree formed by sequence inorder[start, end].
        var root = new TreeNode(postorder[refIndex--]);

        // Find index of node's value in inorder sequence
        // It determine the boundary of the left and right subtree of the current TreeNode
        var index = inorderMap[root.val];

        // Construct right
        root.right = construct(index + 1, end, postorder, ref refIndex, inorderMap);

        // And left subtree
        root.left = construct(start, index - 1, postorder, ref refIndex, inorderMap);

        return root;
    }
}