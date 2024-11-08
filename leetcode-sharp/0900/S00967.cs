namespace leetcode_sharp;

// 967. Numbers With Same Consecutive Differences
// https://leetcode.com/problems/numbers-with-same-consecutive-differences
public class S00967
{
    public int[] NumsSameConsecDiff(int n, int k)
    {
        var res = new List<int>();

        for (var num = 1; num <= 9; ++num)
        {
            Dfs(num, n - 1, k, res);
        }

        return res.ToArray();
    }

    private void Dfs(int num, int n, int k, List<int> res)
    {
        if (n == 0)
        {
            res.Add(num);
        }
        else
        {
            var digit = num % 10;

            if (digit + k <= 9)
            {
                Dfs(num * 10 + digit + k, n - 1, k, res);
            }

            if (k != 0 && digit >= k)
            {
                Dfs(num * 10 + digit - k, n - 1, k, res);
            }
        }
    }
}