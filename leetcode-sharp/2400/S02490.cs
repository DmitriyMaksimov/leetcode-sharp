namespace leetcode_sharp;

// 
// https://leetcode.com/problems/circular-sentence/
public class S02490
{
    public bool IsCircularSentence(string sentence)
    {
        var words = sentence.Split(' ').ToArray();

        for (var i = 1; i < words.Length; i++)
        {
            if (words[i - 1][^1] != words[i][0])
            {
                return false;
            }
        }

        return words[^1][^1] == words[0][0];
    }
}