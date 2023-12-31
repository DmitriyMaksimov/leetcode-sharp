namespace leetcode_sharp;

// 2974. Minimum Number Game
// https://leetcode.com/problems/minimum-number-game
public class S02974
{
    public int[] NumberGame(int[] nums)
    {
        Array.Sort(nums);
        
        for (var i = 0; i < nums.Length - 1; i += 2)
        {
            (nums[i + 1], nums[i]) = (nums[i], nums[i + 1]);
        }

        return nums;
    }
}