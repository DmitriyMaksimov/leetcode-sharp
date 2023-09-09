namespace leetcode_sharp;

// 1408. String Matching in an Array
// https://leetcode.com/problems/string-matching-in-an-array/
public class S01408
{
    public IList<string> StringMatching(string[] words)
    {
        var result = new HashSet<string>();

        for (var i = 0; i < words.Length; i++)
        {
            for (var j = 0; j < words.Length; j++)
            {
                if (i != j && words[i].Contains(words[j]))
                {
                    result.Add(words[j]);
                }
            }
        }

        return result.ToList();
    }
}