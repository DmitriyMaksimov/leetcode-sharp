namespace leetcode_sharp;

// 1255. Maximum Score Words Formed by Letters
// https://leetcode.com/problems/maximum-score-words-formed-by-letters/
public class S01255
{
    public int MaxScoreWords(string[] words, char[] letters, int[] score)
    {
        if (words.Length == 0 || letters.Length == 0 || score.Length == 0)
        {
            return 0;
        }

        var count = new int[score.Length];

        foreach (var ch in letters)
        {
            count[ch - 'a']++;
        }

        return backtrack(words, count, score, 0);
    }

    private static int backtrack(IReadOnlyList<string> words, IList<int> count, IReadOnlyList<int> score, int index)
    {
        var max = 0;

        for (var i = index; i < words.Count; i++)
        {
            var res = 0;
            var isValid = true;
            foreach (var ch in words[i])
            {
                count[ch - 'a']--;
                res += score[ch - 'a'];
                if (count[ch - 'a'] < 0)
                {
                    isValid = false;
                }
            }

            if (isValid)
            {
                res += backtrack(words, count, score, i + 1);
                max = Math.Max(res, max);
            }

            foreach (var ch in words[i])
            {
                count[ch - 'a']++;
            }
        }

        return max;
    }
}