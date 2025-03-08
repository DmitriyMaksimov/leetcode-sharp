namespace leetcode_sharp;

// 2100. Find Good Days to Rob the Bank
// https://leetcode.com/problems/find-good-days-to-rob-the-bank
public class S02100
{
    public IList<int> GoodDaysToRobBank(int[] security, int time)
    {
        var n = security.Length;

        var left = new int[n];
        var right = new int[n];

        for (var i = 1; i < n; i++)
        {
            if (security[i] <= security[i - 1])
            {
                left[i] = left[i - 1] + 1;
            }
        }

        for (var i = n - 2; i >= 0; i--)
        {
            if (security[i] <= security[i + 1])
            {
                right[i] = right[i + 1] + 1;
            }
        }

        var result = new List<int>();

        for (var i = time; i < n - time; i++)
        {
            if (left[i] >= time && right[i] >= time)
            {
                result.Add(i);
            }
        }

        return result;
    }
}
