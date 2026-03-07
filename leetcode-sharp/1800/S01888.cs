namespace leetcode_sharp;

// 1888. Minimum Number of Flips to Make the Binary String Alternating
// https://leetcode.com/problems/minimum-number-of-flips-to-make-the-binary-string-alternating
public class S01888
{
    public int MinFlips(string s)
    {
        var n = s.Length;
        var ss = s + s;

        var diff1 = 0; // mismatches with pattern "010101..."
        var diff2 = 0; // mismatches with pattern "101010..."

        var result = int.MaxValue;
        var left = 0;

        for (var right = 0; right < ss.Length; right++)
        {
            var expected1 = right % 2 == 0 ? '0' : '1';
            var expected2 = right % 2 == 0 ? '1' : '0';

            if (ss[right] != expected1)
            {
                diff1++;
            }

            if (ss[right] != expected2)
            {
                diff2++;
            }

            if (right - left + 1 > n)
            {
                var leftExpected1 = left % 2 == 0 ? '0' : '1';
                var leftExpected2 = left % 2 == 0 ? '1' : '0';

                if (ss[left] != leftExpected1)
                {
                    diff1--;
                }

                if (ss[left] != leftExpected2)
                {
                    diff2--;
                }

                left++;
            }

            if (right - left + 1 == n)
            {
                result = Math.Min(result, Math.Min(diff1, diff2));
            }
        }

        return result;
    }
}
