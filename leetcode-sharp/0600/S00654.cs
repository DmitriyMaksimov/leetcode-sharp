namespace leetcode_sharp;

// 654. Maximum Binary Tree
// https://leetcode.com/problems/maximum-binary-tree
public class S00654
{
    public TreeNode? ConstructMaximumBinaryTree(int[] nums)
    {
        return constructMaximumBinaryTree(nums, 0, nums.Length - 1);
    }

    private static TreeNode? constructMaximumBinaryTree(IReadOnlyList<int> nums, int i, int j)
    {
        if (j < i)
        {
            return null;
        }

        if (i == j)
        {
            return new TreeNode(nums[i]);
        }

        var max = nums[i];
        var index = i;

        for (var k = i + 1; k <= j; k++)
        {
            if (nums[k] > max)
            {
                index = k;
                max = nums[k];
            }
        }

        return new TreeNode(max)
        {
            left = constructMaximumBinaryTree(nums, i, index - 1),
            right = constructMaximumBinaryTree(nums, index + 1, j)
        };
    }
}