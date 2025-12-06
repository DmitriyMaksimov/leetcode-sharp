namespace leetcode_sharp;

// 3736. Minimum Moves to Equal Array Elements III
// https://leetcode.com/problems/minimum-moves-to-equal-array-elements-iii
public class S03736
{
    public int MinMoves(int[] nums)
    {
        var max = nums.Max();
        return nums.Aggregate(0, (current, n) => current + max - n);
    }
}