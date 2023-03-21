namespace leetcode_sharp;

// 283. Move Zeroes
// https://leetcode.com/problems/move-zeroes/
public class S00283
{
    public void MoveZeroes(int[] nums)
    {
        var i = 0;
        while (i < nums.Length && nums[i] != 0)
        {
            ++i;
        }
        
        if (i >= nums.Length)
        {
            return;
        }

        for (var j = i + 1; j < nums.Length; j++)
        {
            if (nums[j] != 0)
            {
                nums[i++] = nums[j];
            }
        }

        for (; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}