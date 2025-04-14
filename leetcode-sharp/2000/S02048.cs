namespace leetcode_sharp;

// 2048. Next Greater Numerically Balanced Number
// https://leetcode.com/problems/next-greater-numerically-balanced-number
public class S02048
{
    public int NextBeautifulNumber(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        var minNumLen = (int)Math.Log10(n) + 1;

        for (var len = minNumLen; len <= minNumLen + 1; ++len)
        {
            var all = new List<int>();
            var counter = new Dictionary<int, int>();
            Backtrack(0, len, 0, counter, all);
            all.Sort();

            foreach (var num in all.Where(num => num > n))
            {
                return num;
            }
        }

        return -1;
    }

    private static void Backtrack(int i, int len, int curNum, Dictionary<int, int> counter, List<int> output)
    {
        if (i == len)
        {
            var isBalanceNumber = true;
            foreach (var (digit, freq) in counter)
            {
                if (freq > 0 && digit != freq)
                {
                    isBalanceNumber = false;
                    break;
                }
            }

            if (isBalanceNumber)
            {
                output.Add(curNum);
            }

            return;
        }

        for (var d = 1; d <= len; ++d)
        {
            counter.TryAdd(d, 0);

            if (counter[d] >= d ||counter[d] + (len - i) < d)
            {
                continue;
            }

            counter[d]++;
            Backtrack(i + 1, len, curNum * 10 + d, counter, output);
            counter[d]--;
        }
    }
}
