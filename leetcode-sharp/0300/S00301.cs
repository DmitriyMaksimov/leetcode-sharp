namespace leetcode_sharp;

// 301. Remove Invalid Parentheses
// https://leetcode.com/problems/remove-invalid-parentheses
public class S00301
{
    public IList<string> RemoveInvalidParentheses(string s)
    {
        var result = new List<string>();

        Remove(s, result, 0, 0, ['(', ')']);

        return result;
    }

    private static void Remove(string s, IList<string> result, int scanStart, int removeStart, char[] par)
    {
        for (int balance = 0, i = scanStart; i < s.Length; ++i)
        {
            if (s[i] == par[0])
            {
                balance++;
            }

            if (s[i] == par[1])
            {
                balance--;
            }

            if (balance >= 0)
            {
                continue;
            }

            for (var j = removeStart; j <= i; ++j)
            {
                if (s[j] == par[1] && (j == removeStart || s[j - 1] != par[1]))
                {
                    Remove(s[..j] + s[(j + 1)..], result, i, j, par);
                }
            }

            return;
        }
        
        var reversed = string.Concat(s.Reverse());

        if (par[0] == '(')
        {
            Remove(reversed, result, 0, 0, [')', '(']);
        }
        else
        {
            result.Add(reversed);
        }
    }
}