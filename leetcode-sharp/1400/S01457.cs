namespace leetcode_sharp;

// 1457. Pseudo-Palindromic Paths in a Binary Tree
// https://leetcode.com/problems/pseudo-palindromic-paths-in-a-binary-tree
public class S01457
{
    public int PseudoPalindromicPaths(TreeNode? root)
    {
        return CountPseudoPalindromicPaths(root, 0);
    }

    private int CountPseudoPalindromicPaths(TreeNode? node, int count)
    {
        if (node == null)
        {
            return 0;
        }

        count ^= 1 << (node.val - 1);

        if (node.left == null && node.right == null)
        {
            // Check if the current path is pseudo-palindromic
            return (count & (count - 1)) == 0 ? 1 : 0;
        }

        var leftPaths = CountPseudoPalindromicPaths(node.left, count);
        var rightPaths = CountPseudoPalindromicPaths(node.right, count);

        return leftPaths + rightPaths;
    }
}