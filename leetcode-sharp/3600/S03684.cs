namespace leetcode_sharp;

// 3684. Maximize Sum of At Most K Distinct Elements
// https://leetcode.com/problems/maximize-sum-of-at-most-k-distinct-elements
public class S03684
{
    public int[] MaxKDistinct(int[] nums, int k)
    {
        return nums.Distinct().OrderDescending().Take(k).ToArray();
    }
}