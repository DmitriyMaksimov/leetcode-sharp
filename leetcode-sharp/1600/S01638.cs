namespace leetcode_sharp;

// 1638. Count Substrings That Differ by One Character
// https://leetcode.com/problems/count-substrings-that-differ-by-one-character
public class S01638
{
    public int CountSubstrings(string s, string t)
    {
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            for (var j = 0; j < t.Length; j++)
            {
                var diff = 0;
        
                for (var p = 0; i + p < s.Length && j + p < t.Length; p++)
                {
                    if (s[i + p] != t[j + p])
                    {
                        diff++;
                    }

                    if (diff == 1)
                    {
                        result++;
                    }

                    if (diff == 2)
                    {
                        break;
                    }
                }
            }
        }

        return result;
    }
}