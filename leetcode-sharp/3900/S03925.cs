namespace leetcode_sharp;

// 3925. Concatenate Array With Reverse
// https://leetcode.com/problems/concatenate-array-with-reverse
public class S03925
{
    public int[] ConcatWithReverse(int[] nums)
    {
        return [.. nums, .. nums.Reverse()];
    }
}