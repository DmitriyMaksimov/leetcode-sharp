namespace leetcode_sharp;

// 1929. Concatenation of Array
// https://leetcode.com/problems/concatenation-of-array/
public class S01929
{
    public int[] GetConcatenation(int[] nums)
    {
        return nums.Concat(nums).ToArray();
    }
}