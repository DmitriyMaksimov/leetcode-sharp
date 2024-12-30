namespace leetcode_sharp;

// 916. Word Subsets
// https://leetcode.com/problems/word-subsets
public class S00916
{
    private const int MaxLetters = 26;

    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        var bMax = new int[MaxLetters];

        foreach (var word in words2)
        {
            var counts = GetLetterCounts(word);

            for (var i = 0; i < MaxLetters; i++)
            {
                bMax[i] = Math.Max(bMax[i], counts[i]);
            }
        }

        var result = new List<string>();

        foreach (var word in words1)
        {
            var counts = GetLetterCounts(word);
            var isUniversal = true;

            for (var i = 0; i < MaxLetters; i++)
            {
                if (counts[i] < bMax[i])
                {
                    isUniversal = false;
                    break;
                }
            }

            if (isUniversal)
            {
                result.Add(word);
            }
        }

        return result;
    }

    private static int[] GetLetterCounts(string s)
    {
        var counts = new int[MaxLetters];

        foreach (var c in s)
        {
            counts[c - 'a']++;
        }

        return counts;
    }
}
