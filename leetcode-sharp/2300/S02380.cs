namespace leetcode_sharp;

// 2380. Time Needed to Rearrange a Binary String
// https://leetcode.com/problems/time-needed-to-rearrange-a-binary-string
public class S02380
{
    public int SecondsToRemoveOccurrences(string s)
    {
        var waitingTime = 0;
        var zeroCount = 0;
        var lastOccurence = s.LastIndexOf('1');

        for (var i = 0; i <= lastOccurence; i++)
        {
            if (i > 0 && s[i] == '1' && s[i - 1] == '1' && zeroCount > 0)
            {
                waitingTime++;
            }

            if (i > 0 && s[i] == '0' && s[i - 1] == '0' && waitingTime > 0)
            {
                waitingTime--;
            }

            if (s[i] == '0')
            {
                zeroCount++;
            }
        }

        return zeroCount + waitingTime;
    }
}
