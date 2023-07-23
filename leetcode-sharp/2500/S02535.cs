namespace leetcode_sharp;

// 2535. Difference Between Element Sum and Digit Sum of an Array
// https://leetcode.com/problems/difference-between-element-sum-and-digit-sum-of-an-array/
public class S02535
{
    public int DifferenceOfSum(int[] nums)
    {
        var sum = 0;
        var digitsSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            sum += num;

            while (num > 0)
            {
                digitsSum += num % 10;
                num /= 10;
            }
        }

        return Math.Abs(sum - digitsSum);
    }
}