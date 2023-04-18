namespace leetcode_sharp;

// 1768. Merge Strings Alternately
// https://leetcode.com/problems/merge-strings-alternately/
public class S01768
{
    public string MergeAlternately(string word1, string word2)
    {
        var result = new char[word1.Length + word2.Length];
        var index1 = 0;
        var index2 = 0;

        while (index1 < word1.Length || index2 < word2.Length)
        {
            if (index1 < word1.Length)
            {
                result[index1 + index2] = word1[index1++];
            }
            
            if (index2 < word2.Length)
            {
                result[index1 + index2] = word2[index2++];
            }
        }
        
        return new string(result);
    }
}