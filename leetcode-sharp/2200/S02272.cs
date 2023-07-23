namespace leetcode_sharp;

// 2272. Substring With Largest Variance
// https://leetcode.com/problems/substring-with-largest-variance/
public class S02272
{
    public int LargestVariance(string s)
    {
        var res = 0;
        var uniqueChars = new HashSet<char>(s.ToCharArray());

        foreach (var a in uniqueChars)
        {
            foreach (var b in uniqueChars)
            {
                var variance = 0;
                var hasB = false;
                var firstB = false;

                foreach (var ch in s)
                {
                    variance += ch == a ? 1 : 0;
                    if (ch == b)
                    {
                        hasB = true;
                        if (firstB && variance >= 0)
                        {
                            firstB = false;
                        }
                        else if (--variance < 0)
                        {
                            firstB = true;
                            variance = -1;
                        }
                    }

                    res = Math.Max(res, hasB ? variance : 0);
                }
            }
        }

        return res;
    }
}