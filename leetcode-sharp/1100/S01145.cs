namespace leetcode_sharp;

// 1145. Binary Tree Coloring Game
// https://leetcode.com/problems/binary-tree-coloring-game
public class S01145
{
    public bool BtreeGameWinningMove(TreeNode? root, int n, int x)
    {
        if (root == null)
        {
            return false;
        }

        if (root.val == x)
        {
            var left = Count(root.left);
            var right = Count(root.right);
            var parent = n - (left + right + 1);

            return parent > left + right || left > parent + right || right > left + parent;
        }

        return BtreeGameWinningMove(root.left, n, x) || BtreeGameWinningMove(root.right, n, x);
    }

    private static int Count(TreeNode? node)
    {
        if (node == null)
        {
            return 0;
        }

        return Count(node.left) + Count(node.right) + 1;
    }
}
