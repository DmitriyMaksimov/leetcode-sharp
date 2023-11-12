namespace leetcode_sharp;

// 2717. Semi-Ordered Permutation
// https://leetcode.com/problems/semi-ordered-permutation
public class S02717
{
    public int SemiOrderedPermutation(int[] nums)
    {
        var n = nums.Length;
        var index = Array.IndexOf(nums, 1);
        var count = index;

        while (nums[0] != 1)
        {
            nums[index] = nums[index - 1];
            nums[index - 1] = 1;
            index--;
        }

        index = Array.IndexOf(nums, n);

        return count + n - index - 1;
    }
}