namespace leetcode_sharp;

// 1131. Maximum of Absolute Value Expression
// https://leetcode.com/problems/maximum-of-absolute-value-expression
public class S01131
{
    public int MaxAbsValExpr(int[] arr1, int[] arr2)
    {
        var n = arr1.Length;
        var result = int.MinValue;
        int[] signs = [1, -1];

        foreach (var sign1 in signs)
        {
            foreach (var sign2 in signs)
            {
                var minValue = int.MaxValue;
                var maxValue = int.MinValue;

                for (var i = 0; i < n; i++)
                {
                    var value = arr1[i] + sign1 * arr2[i] + sign2 * i;
                    minValue = Math.Min(minValue, value);
                    maxValue = Math.Max(maxValue, value);
                }

                result = Math.Max(result, maxValue - minValue);
            }
        }

        return result;
    }
}