namespace leetcode_sharp;

// 2980. Check if Bitwise OR Has Trailing Zeros
// https://leetcode.com/problems/check-if-bitwise-or-has-trailing-zeros
public class S02980
{
    public bool HasTrailingZeros(int[] nums)
    {
        var countOfEvenNumbers = 0;
        
        foreach (var num in nums)
        {
            if (num % 2 != 0) continue;

            if (++countOfEvenNumbers == 2)
            {
                return true;
            }
        }

        return false;
    }
}