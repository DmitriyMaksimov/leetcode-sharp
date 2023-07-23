namespace leetcode_sharp;

// 112. Path Sum
// https://leetcode.com/problems/path-sum/
public class S00112
{
    public bool HasPathSum(TreeNode? root, int targetSum)
    {
        if (root == null)
        {
            return false;
        }

        var newTargetSum = targetSum - root.val;

        if (root.left == null && root.right == null)
        {
            // Leaf node
            return newTargetSum == 0;
        }

        return HasPathSum(root.left, newTargetSum) || HasPathSum(root.right, newTargetSum);
    }
}