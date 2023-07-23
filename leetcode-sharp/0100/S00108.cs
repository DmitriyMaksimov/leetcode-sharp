namespace leetcode_sharp;

// 108. Convert Sorted Array to Binary Search Tree
// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
public class S00108
{
    public TreeNode? SortedArrayToBST(int[] nums)
    {
        return nums.Length == 0 ? null : arrayToBst(nums, 0, nums.Length - 1);
    }

    private static TreeNode? arrayToBst(IReadOnlyList<int> nums, int lo, int hi)
    {
        if (lo > hi)
        {
            return null;
        }
        
        var mid = lo + (hi - lo) / 2;
        var root = new TreeNode(nums[mid])
        {
            left = arrayToBst(nums, lo, mid - 1),
            right = arrayToBst(nums, mid + 1, hi)
        };

        return root;
    }
}