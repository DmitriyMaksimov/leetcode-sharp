namespace leetcode_sharp;

// 1160. Find Words That Can Be Formed by Characters
// https://leetcode.com/problems/find-words-that-can-be-formed-by-characters/
public class S01160
{
    public int CountCharacters(string[] words, string chars)
    {
        const int maxChars = 26;

        var charCounts = new int[maxChars];
        foreach (var c in chars)
        {
            charCounts[c - 'a']++;
        }

        var result = 0;
        foreach (var word in words)
        {
            var wordCounts = new int[maxChars];
            foreach (var c in word)
            {
                wordCounts[c - 'a']++;
            }

            var isGood = true;
            for (var i = 0; i < maxChars; i++)
            {
                if (wordCounts[i] > charCounts[i])
                {
                    isGood = false;
                    break;
                }
            }

            if (isGood)
            {
                result += word.Length;
            }
        }

        return result;
    }
}