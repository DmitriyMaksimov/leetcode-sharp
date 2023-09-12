namespace leetcode_sharp;

// 1935. Maximum Number of Words You Can Type
// https://leetcode.com/problems/maximum-number-of-words-you-can-type/
public class S01935
{
    public int CanBeTypedWords(string text, string brokenLetters)
    {
        var words = text.Split(' ');
        var result = 0;

        foreach (var word in words)
        {
            var isBroken = brokenLetters.Any(letter => word.Contains(letter));

            if (!isBroken)
            {
                result++;
            }
        }

        return result;
    }
}