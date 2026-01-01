namespace leetcode_sharp;

// 66. Plus One
// https://leetcode.com/problems/plus-one
public class S00066
{
    public int[] PlusOne(int[] digits)
    {
        var index = digits.Length - 1;

        for (; index >= 0; --index)
        {
            if (digits[index] < 9)
            {
                ++digits[index];
                return digits;
            }

            digits[index] = 0;
        }

        return digits.Prepend(1).ToArray();
    }
}