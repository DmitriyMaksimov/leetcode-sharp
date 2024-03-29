namespace leetcode_sharp;

// 979. Distribute Coins in Binary Tree
// https://leetcode.com/problems/distribute-coins-in-binary-tree
public class S00979
{
    private int _moves;

    public int DistributeCoins(TreeNode? root)
    {
        PostOrderTraverse(root);
        return _moves;
    }

    private int PostOrderTraverse(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var left = PostOrderTraverse(root.left);
        var right = PostOrderTraverse(root.right);

        _moves += Math.Abs(left) + Math.Abs(right);

        return root.val + left + right - 1;
    }
}