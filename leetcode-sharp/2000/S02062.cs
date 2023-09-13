namespace leetcode_sharp;

// 2062. Count Vowel Substrings of a String
// https://leetcode.com/problems/count-vowel-substrings-of-a-string/
public class S02062
{
    public int CountVowelSubstrings(string word)
    {
        if (word.Length < 5 || word.GroupBy(c => c).Select(g => g.Key).Distinct().Count() < 5)
        {
            return 0;
        }

        var cnt = 0;

        for (var i = 0; i < word.Length - 4; i++)
        {
            for (var j = 0; j < word.Length - i - 4; j++)
            {
                if (isValidSubstring(word[i..(i + j + 5)]))
                {
                    cnt++;
                }
            }
        }

        return cnt;
    }

    private static bool isValidSubstring(string w)
    {
        return w.Contains('a') && w.Contains('e') && w.Contains('i') && w.Contains('o') && w.Contains('u') && w.Distinct().Count() == 5;
    }
}