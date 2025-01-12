namespace leetcode_sharp;

// 2116. Check if a Parentheses String Can Be Valid
// https://leetcode.com/problems/check-if-a-parentheses-string-can-be-valid
public class S02116
{
    public bool CanBeValid(string s, string locked)
    {
        return s.Length % 2 == 0 && Validate(s, locked, '(') && Validate(s, locked, ')');
    }

    private bool Validate(string s, string locked, char op)
    {
        var bal = 0;
        var wild = 0;
        var start = op == '(' ? 0 : s.Length - 1;
        var dir = op == '(' ? 1 : -1;

        for (var i = start; i >= 0 && i < s.Length && wild + bal >= 0; i += dir)
        {
            if (locked[i] == '1')
            {
                bal += s[i] == op ? 1 : -1;
            }
            else
            {
                ++wild;
            }
        }

        return Math.Abs(bal) <= wild;
    }
}
