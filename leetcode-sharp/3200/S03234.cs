namespace leetcode_sharp;

// 3234. Count the Number of Substrings With Dominant Ones
// https://leetcode.com/problems/count-the-number-of-substrings-with-dominant-ones
public class S03234
{
    public int NumberOfSubstrings(string s)
    {
        var n = s.Length;
        var result = 0;

        for (var k = 1; k * k <= n; k++)
        {
            var positionsOfZeros = new List<int>();
            var lastZero = -1;
            var ones = 0;

            for (var right = 0; right < n; right++)
            {
                if (s[right] == '0')
                {
                    positionsOfZeros.Add(right);

                    while (positionsOfZeros.Count > k)
                    {
                        var firstZero = positionsOfZeros[0];
                        ones -= firstZero - lastZero - 1;
                        lastZero = firstZero;
                        positionsOfZeros.RemoveAt(0);
                    }
                }
                else
                {
                    ones++;
                }

                if (positionsOfZeros.Count == k && ones >= k * k)
                {
                    var extendLeft = positionsOfZeros[0] - lastZero;
                    var extendRight = ones - k * k + 1;
                    result += Math.Min(extendLeft, extendRight);
                }
            }
        }

        for (var i = 0; i < n;)
        {
            if (s[i] == '0')
            {
                i++;
                continue;
            }

            var sz = 0;
            while (i < n && s[i] == '1')
            {
                sz++;
                i++;
            }

            result += sz * (sz + 1) / 2;
        }

        return result;
    }
}