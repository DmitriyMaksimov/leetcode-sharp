namespace leetcode_sharp;

// 3403. Find the Lexicographically Largest String From the Box I
// https://leetcode.com/problems/find-the-lexicographically-largest-string-from-the-box-i
public class S03403
{
    public string AnswerString(string word, int numFriends)
    {
        if (numFriends == 1)
        {
            return word;
        }

        var n = word.Length;
        var maxLen = n - numFriends + 1;
        var maxChar = word[0];
        var result = "";

        for (var i = 0; i < n; i++)
        {
            if (word[i] >= maxChar)
            {
                var current = word.Substring(i, Math.Min(maxLen, n - i));
                if (string.CompareOrdinal(current, result) > 0)
                {
                    result = current;
                }

                maxChar = word[i];
            }
        }

        return result;
    }
}
