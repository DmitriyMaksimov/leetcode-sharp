using System.Text;

namespace leetcode_sharp;

// 3838. Weighted Word Mapping
// https://leetcode.com/problems/weighted-word-mapping
public class S03838
{
    public string MapWordWeights(string[] words, int[] weights)
    {
        var result = new StringBuilder();

        foreach (var word in words)
        {
            var sum = word.Sum(c => weights[c - 'a']);
            var mod = sum % 26;
            var mapped = (char)('z' - mod);

            result.Append(mapped);
        }

        return result.ToString();
    }
}