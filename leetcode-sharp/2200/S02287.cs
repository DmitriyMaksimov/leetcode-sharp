namespace leetcode_sharp;

// 2287. Rearrange Characters to Make Target String
// https://leetcode.com/problems/rearrange-characters-to-make-target-string/
public class S02287
{
    public int RearrangeCharacters(string s, string target)
    {
        var freq = new int[26];
        var freq2 = new int[26];

        foreach (var ch in s.ToCharArray())
        {
            freq[ch - 'a']++;
        }

        foreach (var ch in target.ToCharArray())
        {
            freq2[ch - 'a']++;
        }

        return target.ToCharArray().Select(ch => freq[ch - 'a'] / freq2[ch - 'a']).Min();
    }
}