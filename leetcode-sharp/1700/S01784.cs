namespace leetcode_sharp;

// 1784. Check if Binary String Has at Most One Segment of Ones
// https://leetcode.com/problems/check-if-binary-string-has-at-most-one-segment-of-ones/
public class S01784
{
    public bool CheckOnesSegment(string s)
    {
        var ones = 0;
        var zeros = 0;

        foreach (var c in s)
        {
            if (c == '1')
            {
                if (zeros > 0)
                {
                    return false;
                }

                ones++;
            }
            else
            {
                zeros++;
            }
        }

        return ones > 0;
    }
}