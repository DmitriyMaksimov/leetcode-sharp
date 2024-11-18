namespace leetcode_sharp;

// 453. Minimum Moves to Equal Array Elements
// https://leetcode.com/problems/minimum-moves-to-equal-array-elements
public class S00453
{
    public int MinMoves(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var min = nums.Min();

        return nums.Sum(n => n - min);
    }
}
