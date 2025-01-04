using System.Text.RegularExpressions;

namespace leetcode_sharp;

// 966. Vowel Spellchecker
// https://leetcode.com/problems/vowel-spellchecker
public class S00966
{
    public string[] Spellchecker(string[] wordlist, string[] queries)
    {
        HashSet<string> words = [..wordlist];
        Dictionary<string, string> lowerCase = [];
        Dictionary<string, string> maskedVowels = [];

        foreach (var word in wordlist)
        {
            lowerCase.TryAdd(word.ToLower(), word);
            maskedVowels.TryAdd(Regex.Replace(word.ToLower(), "[aeiou]", "."), word);
        }

        var result = new string[queries.Length];

        for (var i = 0; i < queries.Length; ++i)
        {
            var query = queries[i];

            if (words.Contains(query))
            {
                result[i] = query;
                continue;
            }

            var lower = query.ToLower();

            if (lowerCase.TryGetValue(lower, out var value))
            {
                result[i] = value;
            }
            else if (maskedVowels.TryGetValue(Regex.Replace(lower, "[aeiou]", "."), out var value1))
            {
                result[i] = value1;
            }
            else
            {
                result[i] = "";
            }
        }

        return result;
    }
}
