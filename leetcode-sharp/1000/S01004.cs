namespace leetcode_sharp;

// 1004. Max Consecutive Ones III
// https://leetcode.com/problems/max-consecutive-ones-iii/
public class S01004
{
    public int LongestOnes(int[] nums, int k)
    {
        var i = 0;
        var j = 0;

        for (; j < nums.Length; ++j)
        {
            if (nums[j] == 0)
            {
                k--;
            }

            if (k < 0 && nums[i++] == 0)
            {
                k++;
            }
        }

        return j - i;
    }
}