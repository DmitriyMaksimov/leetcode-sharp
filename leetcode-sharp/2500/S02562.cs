namespace leetcode_sharp;

// 2562. Find the Array Concatenation Value
// https://leetcode.com/problems/find-the-array-concatenation-value
public class S02562
{
    public long FindTheArrayConcVal(int[] nums)
    {
        var result = 0L;
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            if (left == right)
            {
                result += nums[left];
            }
            else
            {
                var concatValue = int.Parse(nums[left].ToString() + nums[right]);
                result += concatValue;
            }

            ++left;
            --right;
        }
        
        
        return result;
    }
}