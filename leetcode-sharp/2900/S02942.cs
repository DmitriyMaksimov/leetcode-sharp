namespace leetcode_sharp;

// 2942. Find Words Containing Character
// https://leetcode.com/problems/find-words-containing-character
public class S02942
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        var result = new List<int>();
        
        for (var i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x))
            {
                result.Add(i);
            }
        }

        return result;
    }
}