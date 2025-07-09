namespace leetcode_sharp;

// 978. Longest Turbulent Subarray
// https://leetcode.com/problems/longest-turbulent-subarray
public class S00978
{
    public int MaxTurbulenceSize(int[] arr)
    {
        var n = arr.Length;
        var result = 1;
        var anchor = 0;

        for (var i = 1; i < n; ++i)
        {
            var sign = Math.Sign(arr[i - 1] - arr[i]);

            if (sign == 0)
            {
                anchor = i;
            }
            else if (i == n - 1 || sign * Math.Sign(arr[i] - arr[i + 1]) != -1)
            {
                result = Math.Max(result, i - anchor + 1);
                anchor = i;
            }
        }

        return result;
    }
}