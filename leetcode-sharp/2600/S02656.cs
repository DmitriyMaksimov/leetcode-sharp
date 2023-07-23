namespace leetcode_sharp;

// 2656. Maximum Sum With Exactly K Elements
// https://leetcode.com/problems/maximum-sum-with-exactly-k-elements/
public class S02656
{
    public int MaximizeSum(int[] nums, int k)
    {
        var max = nums.Max();
        var result = 0;
        
        while (k-- > 0)
        {
            result += max++;
        }

        return result;
    }
}