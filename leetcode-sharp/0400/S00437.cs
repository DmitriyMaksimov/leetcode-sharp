namespace leetcode_sharp;

// 437. Path Sum III
// https://leetcode.com/problems/path-sum-iii/
public class S00437
{
    private readonly Dictionary<long, int> _prefixSum = new() {{0, 1}};
    private int _target;

    public int PathSum(TreeNode? root, int targetSum)
    {
        _target = targetSum;
        return helper(root, 0);
    }

    private int helper(TreeNode? root, long currentSum)
    {
        if (root == null)
        {
            return 0;
        }

        currentSum += root.val;
        
        var result = _prefixSum.GetValueOrDefault(currentSum - _target);

        _prefixSum[currentSum] = _prefixSum.GetValueOrDefault(currentSum) + 1;
        result += helper(root.left, currentSum) + helper(root.right, currentSum);
        _prefixSum[currentSum] -= 1;
        
        return result;
    }
}