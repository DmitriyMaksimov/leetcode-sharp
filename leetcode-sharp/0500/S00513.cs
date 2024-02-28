namespace leetcode_sharp;

// 513. Find Bottom Left Tree Value
// https://leetcode.com/problems/find-bottom-left-tree-value
public class S00513
{
    public int FindBottomLeftValue(TreeNode? root)
    {
        return findBottomLeftValue(root, 1, [0, 0]);
    }

    private static int findBottomLeftValue(TreeNode? root, int depth, int[] res)
    {
        if (res[1] < depth)
        {
            res[0] = root!.val;
            res[1] = depth;
        }

        if (root?.left != null) findBottomLeftValue(root.left, depth + 1, res);
        if (root?.right != null) findBottomLeftValue(root.right, depth + 1, res);

        return res[0];
    }
}