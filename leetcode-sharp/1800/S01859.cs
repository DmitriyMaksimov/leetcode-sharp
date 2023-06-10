namespace leetcode_sharp;

// 1859. Sorting the Sentence
// https://leetcode.com/problems/sorting-the-sentence/
public class S01859
{
    public string SortSentence(string s)
    {
        var words = new string[9];

        foreach (var wordAndIndex in s.Split(' '))
        {
            var index = wordAndIndex[^1] - '1';
            words[index] = wordAndIndex[..^1];
        }
        
        return string.Join(" ", words.Where(x => !string.IsNullOrEmpty(x)));
    }
}