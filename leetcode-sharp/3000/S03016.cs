namespace leetcode_sharp;

// 3016. Minimum Number of Pushes to Type Word II
// https://leetcode.com/problems/minimum-number-of-pushes-to-type-word-ii
public class S03016
{
    public int MinimumPushes(string word)
    {
        const int numberOfLetters = 26;
        const int keys = 8;

        var freq = new int[numberOfLetters];

        foreach (var c in word)
        {
            freq[c - 'a']++;
        }

        Array.Sort(freq, (a, b) => b - a);

        var result = 0;

        for (var i = 0; i < numberOfLetters; i++)
        {
            result += freq[i] * (i / keys + 1);
        }

        return result;
    }
}