namespace leetcode_sharp;

// 1347. Minimum Number of Steps to Make Two Strings Anagram
// https://leetcode.com/problems/minimum-number-of-steps-to-make-two-strings-anagram
public class S01347
{
    public int MinSteps(string s, string t)
    {
        const int maxLetters = 26;

        var arrS = new int[maxLetters];
        var arrT = new int[maxLetters];

        foreach (var c in s)
        {
            arrS[c - 'a']++;
        }

        foreach (var c in t)
        {
            arrT[c - 'a']++;
        }

        var count = 0;

        for (var i = 0; i < maxLetters; i++)
        {
            count += Math.Max(arrS[i] - arrT[i], 0);
        }

        return count;
    }
}