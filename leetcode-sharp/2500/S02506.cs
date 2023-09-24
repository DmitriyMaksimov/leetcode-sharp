namespace leetcode_sharp;

// 2506. Count Pairs Of Similar Strings
// https://leetcode.com/problems/count-pairs-of-similar-strings/
public class S02506
{
    public int SimilarPairs(string[] words)
    {
        var result = 0;

        for (var i = 0; i < words.Length; i++)
        {
            for (var j = i + 1; j < words.Length; j++)
            {
                if (isSimilar(words[i], words[j]))
                {
                    result++;
                }
            }
        }

        return result;
    }
    
    private static bool isSimilar(string a, string b)
    {
        var hashSet = new HashSet<char>(a);
        var hashSet2 = new HashSet<char>(b);
        
        return hashSet.SetEquals(hashSet2);
    }
}