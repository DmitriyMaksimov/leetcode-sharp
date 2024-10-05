namespace leetcode_sharp;

// 398. Random Pick Index
// https://leetcode.com/problems/random-pick-index
public class S00398
{
public class Solution
{
    private readonly int[] _nums;

    public Solution(int[] nums)
    {
        _nums = nums;
    }

    public int Pick(int target)
    {
        var result = -1;
        var count = 0;
        for (var i = 0; i < _nums.Length; i++)
        {
            if (_nums[i] != target)
            {
                continue;
            }

            if (Random.Shared.Next(++count) == 0)
            {
                result = i;
            }
        }

        return result;
    }
}
}
