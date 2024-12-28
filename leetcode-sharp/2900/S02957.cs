namespace leetcode_sharp;

// 2957. Remove Adjacent Almost-Equal Characters
// https://leetcode.com/problems/remove-adjacent-almost-equal-characters
public class S02957
{
    public int RemoveAlmostEqualCharacters(string word)
    {
        var result = 0;

        for (var i = 1; i < word.Length; ++i)
        {
            if (Math.Abs(word[i] - word[i - 1]) > 1)
            {
                continue;
            }

            ++result;
            ++i;
        }

        return result;
    }
}
