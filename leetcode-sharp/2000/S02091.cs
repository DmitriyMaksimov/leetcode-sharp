namespace leetcode_sharp;

// 2091. Removing Minimum and Maximum From Array
// https://leetcode.com/problems/removing-minimum-and-maximum-from-array
public class S02091
{
    public int MinimumDeletions(int[] nums)
    {
        var minIndex = Array.IndexOf(nums, nums.Min());
        var maxIndex = Array.IndexOf(nums, nums.Max());
        var i = Math.Min(minIndex, maxIndex);
        var j = Math.Max(minIndex, maxIndex);

        return Math.Min(Math.Min(j + 1, nums.Length - i), i + 1 + nums.Length - j);
    }
}
