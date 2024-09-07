namespace leetcode_sharp;

// 1387. Sort Integers by The Power Value
// https://leetcode.com/problems/sort-integers-by-the-power-value
public class S01387
{
    public int GetKth(int lo, int hi, int k)
    {
        var numbers = Enumerable.Range(lo, hi - lo + 1);

        return numbers.Select(n => (n, GetPower(n))).OrderBy(pair => pair.Item2).ThenBy(pair => pair.Item1).Skip(k - 1).Take(1).First().Item1;
    }

    private static int GetPower(int n)
    {
        var power = 0;

        while (n != 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = n * 3 + 1;
            }

            ++power;
        }

        return power;
    }
}
