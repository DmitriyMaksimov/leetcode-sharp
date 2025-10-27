namespace leetcode_sharp;

// 3701. Compute Alternating Sum
// https://leetcode.com/problems/compute-alternating-sum
public class S03701
{
    public int AlternatingSum(int[] nums)
    {
        return nums.Select((t, i) => i % 2 == 0 ? t : -t).Sum();
    }
}