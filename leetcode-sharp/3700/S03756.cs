namespace leetcode_sharp;

// 3756. Concatenate Non-Zero Digits and Multiply by Sum II
// https://leetcode.com/problems/concatenate-non-zero-digits-and-multiply-by-sum-ii
public class S03756
{
    private const int Mod = 1_000_000_007;
    private const int Max = 100_001;
    private static readonly int[] Pow = BuildPow();

    private static int[] BuildPow()
    {
        var pow = new int[Max];
        pow[0] = 1;

        for (var i = 1; i < Max; i++)
        {
            pow[i] = (int)(pow[i - 1] * 10L % Mod);
        }

        return pow;
    }

    public int[] SumAndMultiply(string s, int[][] queries)
    {
        var n = s.Length;
        var digitSum = new int[n + 1];
        var compressedValue = new int[n + 1];
        var compressedLength = new int[n + 1];

        for (var i = 0; i < n; i++)
        {
            var digit = s[i] - '0';

            digitSum[i + 1] = digitSum[i] + digit;

            if (digit > 0)
            {
                compressedValue[i + 1] = (int)((compressedValue[i] * 10L + digit) % Mod);
                compressedLength[i + 1] = compressedLength[i] + 1;
            }
            else
            {
                compressedValue[i + 1] = compressedValue[i];
                compressedLength[i + 1] = compressedLength[i];
            }
        }

        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var left = queries[i][0];
            var right = queries[i][1] + 1;
            var removedPrefix = (long)compressedValue[left] * Pow[compressedLength[right] - compressedLength[left]] % Mod;
            var compressedSubstring = (compressedValue[right] - removedPrefix + Mod) % Mod;
            var sum = digitSum[right] - digitSum[left];

            result[i] = (int)(compressedSubstring * sum % Mod);
        }

        return result;
    }
}