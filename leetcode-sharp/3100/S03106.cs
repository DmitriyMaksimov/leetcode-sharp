namespace leetcode_sharp;

// 3106. Lexicographically Smallest String After Operations With Constraint
// https://leetcode.com/problems/lexicographically-smallest-string-after-operations-with-constraint
public class S03106
{
    public string GetSmallestString(string s, int k)
    {
        var charArray = s.ToCharArray();
        for (var i = 0; i < s.Length && k > 0; ++i)
        {
            var dist = Math.Min(s[i] - 'a', 'z' - s[i] + 1);
            charArray[i] = dist <= k ? 'a' : (char)(s[i] - k);
            k -= dist;
        }

        return new string(charArray);
    }
}
