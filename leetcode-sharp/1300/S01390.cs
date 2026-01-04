namespace leetcode_sharp;

// 1390. Four Divisors
// https://leetcode.com/problems/four-divisors
public class S01390
{
    public int SumFourDivisors(int[] nums)
    {
        return nums.Aggregate(0, (current, n) => current + SumOf4Divisors(n));
    }

    private static int SumOf4Divisors(int n)
    {
        var result = new List<int>();
        
        for (var i = (int)Math.Sqrt(n); i > 0; --i)
        {
            if (n % i != 0) continue;
            
            result.Add(i);
                
            if (i != n / i)
            {
                result.Add(n / i);
            }
        }

        return result.Count == 4 ? result.Sum() : 0;
    }
}