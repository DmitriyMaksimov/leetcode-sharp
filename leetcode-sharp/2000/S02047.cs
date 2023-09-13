namespace leetcode_sharp;

// 2047. Count Valid Words in Sentence
// https://leetcode.com/problems/count-valid-words-in-sentence/
public class S02047
{
    public int CountValidWords(string sentence)
    {
        return sentence.Split(' ').Where(word => word.Length != 0).Count(isValid);
    }

    private static bool isValid(string word)
    {
        var chars = word.ToCharArray();
        var length = chars.Length;

        if (length == 0)
        {
            return false;
        }

        if (length == 1)
        {
            if (chars[0] == '-')
            {
                return false;
            }

            return "!,.".Contains(chars[0]) || char.IsLower(chars[0]);
        }

        var hasHyphen = false;

        for (var i = 0; i < length; i++)
        {
            if (chars[i] == '-')
            {
                if (hasHyphen || i == 0 || i == length - 1 || !char.IsLower(chars[i - 1]) || !char.IsLower(chars[i + 1]))
                {
                    return false;
                }

                hasHyphen = true;
            }
            else if ("!,.".Contains(chars[i]))
            {
                if (i < length - 1)
                {
                    return false;
                }
            }
            else if (!char.IsLower(chars[i]))
            {
                return false;
            }
        }

        return true;
    }
}