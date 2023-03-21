namespace leetcode_sharp;

// 392. Is Subsequence
// https://leetcode.com/problems/is-subsequence/
public class S00392
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length > t.Length)
        {
            return false;
        }

        var index = 0;
        foreach (var ch in s)
        {
            var found = false;
            for (var j = index; j < t.Length; j++)
            {
                if (ch == t[j])
                {
                    index = j + 1;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                return false;
            }
        }
        
        return true;
    }
}