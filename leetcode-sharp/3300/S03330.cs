namespace leetcode_sharp;

// 3330. Find the Original Typed String I
// https://leetcode.com/problems/find-the-original-typed-string-i
public class S03330
{
    public int PossibleStringCount(string word)
    {
        var count = 1;

        for (var i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
            {
                ++count;
            }
        }

        return count;
    }
}