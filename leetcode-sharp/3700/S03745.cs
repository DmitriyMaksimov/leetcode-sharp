namespace leetcode_sharp;

// 3745. Maximize Expression of Three Elements
// https://leetcode.com/problems/maximize-expression-of-three-elements
public class S03745
{
    public int MaximizeExpressionOfThree(int[] nums)
    {
        var max = int.MinValue;
        var max2 = int.MinValue;
        var min = int.MaxValue;

        foreach (var n in nums)
        {
            min = Math.Min(min, n);

            if (n > max)
            {
                max2 = max;
                max = n;
            }
            else if (n > max2)
            {
                max2 = n;
            }
        }

        return max + max2 - min;
    }
}