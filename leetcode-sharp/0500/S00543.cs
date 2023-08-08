namespace leetcode_sharp;

// 543. Diameter of Binary Tree
// https://leetcode.com/problems/diameter-of-binary-tree/
public class S00543
{
    private int _answer;

    public int DiameterOfBinaryTree(TreeNode? root)
    {
        maxDepth(root);
        return _answer;
    }

    private int maxDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var leftHeight = maxDepth(root.left);
        var rightHeight = maxDepth(root.right);
        
        _answer = Math.Max(_answer, leftHeight + rightHeight);

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}