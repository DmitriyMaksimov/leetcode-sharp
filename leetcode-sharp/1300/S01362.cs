namespace leetcode_sharp;

// 1362. Closest Divisors
// https://leetcode.com/problems/closest-divisors
public class S01362
{
    public int[] ClosestDivisors(int num)
    {
        for (var i = (int)Math.Sqrt(num + 2); i > 0; --i)
        {
            if ((num + 1) % i == 0)
            {
                return [i, (num + 1) / i];
            }

            if ((num + 2) % i == 0)
            {
                return [i, (num + 2) / i];
            }
        }

        return [];
    }
}
