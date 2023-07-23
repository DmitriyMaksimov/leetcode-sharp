namespace leetcode_sharp;

// 2744. Find Maximum Number of String Pairs
// https://leetcode.com/problems/find-maximum-number-of-string-pairs/
public class S02744
{
    public int MaximumNumberOfStringPairs(string[] words)
    {
        var result = 0;
        
        for (var i = 0; i < words.Length; i++)
        {
            for (var j = i + 1; j < words.Length; j++)
            {
                if (words[i] == string.Join("", words[j].Reverse()))
                {
                    ++result;
                }
            }
        }
        
        return result;
    }
}