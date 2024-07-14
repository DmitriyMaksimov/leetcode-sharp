namespace leetcode_sharp;

// 3190. Find Minimum Operations to Make All Elements Divisible by Three
// https://leetcode.com/problems/find-minimum-operations-to-make-all-elements-divisible-by-three
public class S03190
{
    public int MinimumOperations(int[] nums)
    {
        return nums.Count(x => x % 3 != 0);
    }
}