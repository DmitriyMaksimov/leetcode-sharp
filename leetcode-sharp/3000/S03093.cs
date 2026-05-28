namespace leetcode_sharp;

// 3093. Longest Common Suffix Queries
// https://leetcode.com/problems/longest-common-suffix-queries
public class S03093
{
    private class TrieNode
    {
        public readonly TrieNode?[] Children = new TrieNode[26];
        public int BestLen = int.MaxValue;
        public int BestIndex = int.MaxValue;
    }

    public int[] StringIndices(string[] wordsContainer, string[] wordsQuery)
    {
        var root = new TrieNode();

        for (var i = 0; i < wordsContainer.Length; i++)
        {
            var word = wordsContainer[i];
            var len = word.Length;
            var curr = root;

            if (len < curr.BestLen || (len == curr.BestLen && i < curr.BestIndex))
            {
                curr.BestLen = len;
                curr.BestIndex = i;
            }

            for (var j = len - 1; j >= 0; j--)
            {
                var charIdx = word[j] - 'a';
                curr.Children[charIdx] ??= new TrieNode();
                curr = curr.Children[charIdx];

                if (len < curr!.BestLen || (len == curr.BestLen && i < curr.BestIndex))
                {
                    curr.BestLen = len;
                    curr.BestIndex = i;
                }
            }
        }

        var result = new int[wordsQuery.Length];

        for (var i = 0; i < wordsQuery.Length; i++)
        {
            var query = wordsQuery[i];
            var len = query.Length;
            var curr = root;

            for (var j = len - 1; j >= 0; j--)
            {
                var charIdx = query[j] - 'a';

                if (curr!.Children[charIdx] == null)
                {
                    break;
                }

                curr = curr.Children[charIdx];
            }

            result[i] = curr!.BestIndex;
        }

        return result;
    }
}