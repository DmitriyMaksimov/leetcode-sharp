namespace leetcode_sharp;

// 678. Valid Parenthesis String
// https://leetcode.com/problems/valid-parenthesis-string
public class S00678
{
    public bool CheckValidString(string s)
    {
        var cMin = 0;
        var cMax = 0;

        foreach (var c in s)
        {
            switch (c)
            {
                case '(':
                    cMax++;
                    cMin++;
                    break;
                case ')':
                    cMax--;
                    cMin--;
                    break;
                case '*':
                    cMax++;
                    cMin--;
                    break;
            }

            if (cMax < 0)
            {
                return false;
            }

            cMin = Math.Max(cMin, 0);
        }

        return cMin == 0;
    }
}