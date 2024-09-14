namespace leetcode_sharp;

// 1781. Sum of Beauty of All Substrings
// https://leetcode.com/problems/sum-of-beauty-of-all-substrings
public class S01781
{
    public int BeautySum(string s)
    {
        const int maxLetters = 26;
        var result = 0;

        for (var i = 0; i < s.Length; ++i)
        {
            var cnt = new int[maxLetters];
            var maxF = 0;
            var minF = 0;

            for (var j = i; j < s.Length; ++j)
            {
                var idx = s[j] - 'a';
                maxF = Math.Max(maxF, ++cnt[idx]);

                if (minF >= cnt[idx] - 1)
                {
                    minF = cnt[idx];
                    for (var k = 0; k < maxLetters; ++k)
                    {
                        minF = Math.Min(minF, cnt[k] == 0 ? int.MaxValue : cnt[k]);
                    }
                }

                result += maxF - minF;
            }
        }

        return result;
    }
}
