namespace leetcode_sharp;

// 404. Sum of Left Leaves
// https://leetcode.com/problems/sum-of-left-leaves/
public class S00404
{
    public int SumOfLeftLeaves(TreeNode? root)
    {
        return sum(root);
    }

    private static int sum(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var leftSum = 0;
        if (root.left is {left: null} && root.left.right == null)
        {
            leftSum += root.left.val;
        }

        var leftSubtreeSum = sum(root.left);
        var rightSubtreeSum = sum(root.right);
        return leftSum + leftSubtreeSum + rightSubtreeSum;
    }
}