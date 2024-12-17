namespace leetcode_sharp;

// 2559. Count Vowel Strings in Ranges
// https://leetcode.com/problems/count-vowel-strings-in-ranges
public class S02559
{
    public int[] VowelStrings(string[] words, int[][] queries)
    {
        HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u'];

        var prefixSum = new List<int> { 0 };

        foreach (var w in words)
        {
            var startsWithVowel = vowels.Contains(w[0]);
            var endsWithVowel = vowels.Contains(w[^1]);
            prefixSum.Add(prefixSum.Last() + (startsWithVowel && endsWithVowel ? 1 : 0));
        }

        var result = new List<int>();

        foreach (var q in queries)
        {
            var start = q[0];
            var end = q[1];
            result.Add(prefixSum[end + 1] - prefixSum[start]);
        }

        return result.ToArray();
    }
}
