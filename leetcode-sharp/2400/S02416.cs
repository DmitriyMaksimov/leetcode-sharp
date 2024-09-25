namespace leetcode_sharp;

// 2416. Sum of Prefix Scores of Strings
// https://leetcode.com/problems/sum-of-prefix-scores-of-strings/
public class S02416
{
    private class Trie
    {
        public readonly Trie?[] Tries = new Trie[26];
        public int Visited = 0;
    }

    public int[] SumPrefixScores(string[] words)
    {
        var trie = new Trie();
        var ans = new int[words.Length];
        var k = 0;

        foreach (var word in words)
        {
            var t = trie;

            foreach (var c in word.Select(ch => ch - 'a'))
            {
                if (t!.Tries[c] == null) t.Tries[c] = new Trie();
                t.Tries[c]!.Visited++;
                t = t.Tries[c];
            }
        }

        foreach (var word in words)
        {
            var t = trie;
            var curr = 0;
            foreach (var c in word.Select(ch => ch - 'a'))
            {
                curr += t.Tries[c].Visited;
                t = t.Tries[c];
            }

            ans[k++] = curr;
        }

        return ans;
    }
}
