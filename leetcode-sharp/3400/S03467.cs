namespace leetcode_sharp;

// 3467. Transform Array by Parity
// https://leetcode.com/problems/transform-array-by-parity
public class S03467
{
    public int[] TransformArray(int[] nums)
    {
        var evenCount = nums.Count(x => x % 2 == 0);
        return Enumerable.Repeat(0, evenCount).Concat(Enumerable.Repeat(1, nums.Length - evenCount)).ToArray();
    }
}
