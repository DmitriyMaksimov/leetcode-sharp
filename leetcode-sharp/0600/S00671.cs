namespace leetcode_sharp;

// 671. Second Minimum Node In a Binary Tree
// https://leetcode.com/problems/second-minimum-node-in-a-binary-tree/
public class S00671
{
    public int FindSecondMinimumValue(TreeNode? root)
    {
        if (root?.left == null)
        {
            return -1;
        }

        var left = root.left.val == root.val ? FindSecondMinimumValue(root.left) : root.left.val;
        var right = root.right!.val == root.val ? FindSecondMinimumValue(root.right) : root.right.val;

        return left == -1 || right == -1 ? Math.Max(left, right) : Math.Min(left, right);
    }
}