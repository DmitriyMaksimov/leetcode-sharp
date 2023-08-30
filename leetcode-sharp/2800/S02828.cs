namespace leetcode_sharp;

// 2828. Check if a String Is an Acronym of Words
// https://leetcode.com/problems/check-if-a-string-is-an-acronym-of-words/
public class S02828
{
    public bool IsAcronym(IList<string> words, string s)
    {
        if (s.Length != words.Count)
        {
            return false;
        }

        var i = 0;
        foreach (var word in words)
        {
            if (word.Length == 0)
            {
                continue;
            }

            if (word[0] != s[i])
            {
                return false;
            }

            i++;
        }

        return true;
    }
}