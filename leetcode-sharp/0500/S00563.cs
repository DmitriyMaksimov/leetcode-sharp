namespace leetcode_sharp;

// 563. Binary Tree Tilt
// https://leetcode.com/problems/binary-tree-tilt/
public class S00563
{
    private int _answer;

    public int FindTilt(TreeNode? root)
    {
        helper(root);
        return _answer;
    }

    private int helper(TreeNode? root)
    {
        if (root == null) return 0;

        var leftSum = helper(root.left);
        var rightSum = helper(root.right);

        _answer += Math.Abs(leftSum - rightSum);

        return root.val + leftSum + rightSum;
    }
}