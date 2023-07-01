namespace leetcode_sharp;

// 2305. Fair Distribution of Cookies
// https://leetcode.com/problems/fair-distribution-of-cookies/
public class S02305
{
    private int[] _cookiesOfChild;
    private int _result = int.MaxValue;

    public int DistributeCookies(int[] cookies, int k)
    {
        _cookiesOfChild = new int[k];
        backTrack(cookies, 0);
        return _result;
    }

    private void backTrack(IReadOnlyList<int> cookies, int i)
    {
        for (var j = 0; j < _cookiesOfChild.Length; j++)
        {
            // Temporary give `cookies[i]` to child `j`
            _cookiesOfChild[j] += cookies[i];

            if (i == cookies.Count - 1)
            {
                _result = Math.Min(_result, _cookiesOfChild.Max());
            }
            else
            {
                backTrack(cookies, i + 1);
            }

            // Subtract the cookies
            _cookiesOfChild[j] -= cookies[i];
        }
    }
}