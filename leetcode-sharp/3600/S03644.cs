namespace leetcode_sharp;

// 3644. Maximum K to Sort a Permutation
// https://leetcode.com/problems/maximum-k-to-sort-a-permutation
public class S03644
{
    public int SortPermutation(int[] nums)
    {
        var mask = nums.Where((t, i) => t != i).Aggregate(int.MaxValue, (current, t) => current & t);

        return mask == int.MaxValue ? 0 : mask;
    }
}