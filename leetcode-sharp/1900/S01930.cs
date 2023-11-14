namespace leetcode_sharp;

// 1930. Unique Length-3 Palindromic Subsequences
// https://leetcode.com/problems/unique-length-3-palindromic-subsequences
public class S01930
{
    public int CountPalindromicSubsequence(string s)
    {
        var count = 0;
        var dictionary = new bool[26];

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i] - 'a';

            if (dictionary[c])
            {
                continue;
            }

            var j = s.Length - 1;

            while (j > i && s[i] != s[j])
            {
                j--;
            }

            count += countDistinctCharacters(s, i + 1, j - 1);
            dictionary[c] = true;
        }

        return count;
    }

    private static int countDistinctCharacters(string s, int x, int y)
    {
        if (x > y)
        {
            return 0;
        }

        var count = 0;
        var dict = new bool[26];

        for (var i = x; i <= y; i++)
        {
            var c = s[i] - 'a';
        
            if (!dict[c])
            {
                count++;
            }

            dict[c] = true;
        }

        return count;
    }
}