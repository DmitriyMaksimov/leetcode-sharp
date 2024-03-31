namespace leetcode_sharp;

// 2186. Minimum Number of Steps to Make Two Strings Anagram II
// https://leetcode.com/problems/minimum-number-of-steps-to-make-two-strings-anagram-ii
public class S02186
{
    public int MinSteps(string s, string t)
    {
        var sCounter = new int[26];
        foreach (var ch in s)
        {
            sCounter[ch - 'a']++;
        }

        var tCounter = new int[26];
        foreach (var ch in t)
        {
            tCounter[ch - 'a']++;
        }

        var answer = 0;
        for (var i = 0; i < 26; i++)
        {
            answer += Math.Abs(sCounter[i] - tCounter[i]);
        }

        return answer;
    }
}