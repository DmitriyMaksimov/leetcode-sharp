namespace leetcode_sharp;

// 22. Generate Parentheses
// https://leetcode.com/problems/generate-parentheses/
public class S00022
{
    public IList<string> GenerateParenthesis(int n)
    {
        var res = new List<string>();
        helper(res, 0, 0, "", n);
        return res;
    }

    private static void helper(ICollection<string> res, int left, int right, string s, int n)
    {
        if (s.Length == n * 2)
        {
            res.Add(s);
            return;
        }

        if (left < n)
        {
            helper(res, left + 1, right, s + "(", n);
        }

        if (right < left)
        {
            helper(res, left, right + 1, s + ")", n);
        }
    }
}