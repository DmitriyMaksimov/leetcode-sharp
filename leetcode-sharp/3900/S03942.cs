namespace leetcode_sharp;

// 3942. Minimum Operations to Sort a Permutation
// https://leetcode.com/problems/minimum-operations-to-sort-a-permutation
public class S03942
{
    public int MinOperations(int[] nums)
    {
        var n = nums.Length;
        var asc = 1;
        var dsc = 1;

        for (var i = 1; i < n; i++)
        {
            if (nums[i] == (nums[i - 1] + 1) % n)
            {
                asc++;
            }

            if (nums[i - 1] == (nums[i] + 1) % n)
            {
                dsc++;
            }
        }

        if (asc == n && nums[0] == 0)
        {
            return 0;
        }

        if (asc == n)
        {
            return Math.Min(n - nums[0], nums[0] + 2);
        }

        if (dsc == n)
        {
            return Math.Min(n - nums[n - 1], nums[n - 1]) + 1;
        }

        return -1;
    }
}
