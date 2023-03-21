namespace leetcode_sharp;

// 77. Combinations
// https://leetcode.com/problems/combinations/
public class S00077
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var result = new List<IList<int>>();

        var i = 0;
        var p = new int[k];
        while (i >= 0)
        {
            p[i]++;
            if (p[i] > n) --i;
            else if (i == k - 1)
            {
                result.Add(p.ToList());
            }
            else
            {
                ++i;
                p[i] = p[i - 1];
            }
        }

        return result;
    }
}