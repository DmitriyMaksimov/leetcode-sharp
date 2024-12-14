namespace leetcode_sharp;

// 3228. Maximum Number of Operations to Move Ones to the End
// https://leetcode.com/problems/maximum-number-of-operations-to-move-ones-to-the-end
public class S03228
{
    public int MaxOperations(string s)
    {
        var result = 0;
        var ones = 0;

        for (var i = 0; i < s.Length; ++i)
        {
            ones += s[i] - '0';

            if (i > 0 && s[i] < s[i - 1])
            {
                result += ones;
            }
        }

        return result;
    }
}
