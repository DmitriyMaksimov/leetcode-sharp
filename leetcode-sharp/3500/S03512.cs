namespace leetcode_sharp;

// 3512. Minimum Operations to Make Array Sum Divisible by K
// https://leetcode.com/problems/minimum-operations-to-make-array-sum-divisible-by-k
public class S03512
{
    public int MinOperations(int[] nums, int k)
    {
        return nums.Sum() % k;
    }
}
