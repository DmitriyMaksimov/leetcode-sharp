namespace leetcode_sharp;

// 387. First Unique Character in a String
// https://leetcode.com/problems/first-unique-character-in-a-string/
public class S00387
{
    public int FirstUniqChar(string s)
    {
        var counts = new int[26];
        foreach (var ch in s)
        {
            counts[ch - 'a']++;
        }
        
        for (var i = 0; i < s.Length; i++)
        {
            if (counts[s[i] - 'a'] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}