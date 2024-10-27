namespace leetcode_sharp;

// 462. Minimum Moves to Equal Array Elements II
// https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii
public class S00462
{
    public int MinMoves2(int[] nums)
    {
        Array.Sort(nums);
        var i = 0;
        var j = nums.Length - 1;
        var count = 0;

        while (i < j)
        {
            count += nums[j--] - nums[i++];
        }

        return count;
    }
}
