namespace leetcode_sharp;

// 664. Strange Printer
// https://leetcode.com/problems/strange-printer/
public class S00664
{
    public int StrangePrinter(string s)
    {
        var n = s.Length;

        if (n == 0)
        {
            return 0;
        }
        
        // Shorten the original string, like reduce aaabbb to ab
        var tempStr = new string(s[0], 1);

        for (var i = 1; i < n; i++)
        {
            if (s[i] != tempStr[^1])
            {
                tempStr += s[i];
            }
        }

        s = tempStr;
        n = s.Length;

        var state = new int[n, n];

        for (var i = 0; i < n; i++)
        {
            state[i, i] = 1;
        }

        for (var i = n - 1; i >= 0; i--)
        {
            for (var dist = 1; dist + i < n; dist++)
            {
                var j = dist + i;
                if (dist == 1)
                {
                    state[i, j] = s[i] == s[j] ? 1 : 2;
                    continue;
                }

                state[i, j] = int.MaxValue;
                for (var k = i; k + 1 <= j; k++)
                {
                    var tmp = state[i, k] + state[k + 1, j];
                    state[i, j] = Math.Min(state[i, j], tmp);
                }

                if (s[i] == s[j])
                {
                    state[i, j]--;
                }
            }
        }

        return state[0, n - 1];
    }
}