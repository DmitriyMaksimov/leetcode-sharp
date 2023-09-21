namespace leetcode_sharp;

// 
// https://leetcode.com/problems/min-max-game
public class S02293
{
    public int MinMaxGame(int[] nums)
    {
        for (var n = nums.Length; n > 1; n -= n / 2)
        {
            for (var i = 0; i < n / 2; i++)
            {
                var val1 = nums[2 * i];
                var val2 = nums[2 * i + 1];

                nums[i] = i % 2 == 0 ? Math.Min(val1, val2) : Math.Max(val1, val2);
            }
        }

        return nums[0];
    }
}