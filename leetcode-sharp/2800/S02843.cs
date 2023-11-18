namespace leetcode_sharp;

// 2843. Count Symmetric Integers
// https://leetcode.com/problems/count-symmetric-integers
public class S02843
{
    public int CountSymmetricIntegers(int low, int high)
    {
        var result = 0;

        for (var i = low; i <= high; ++i)
        {
            var s = i.ToString();
            var n = s.Length;

            if (n % 2 != 0) continue;

            var diff = 0;

            for (var j = 0; j < n / 2; ++j)
            {
                diff += s[j] - s[n - j - 1];
            }

            if (diff == 0) result++;
        }

        return result;
    }
}