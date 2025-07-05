namespace leetcode_sharp;

// 3591. Check if Any Element Has Prime Frequency
// https://leetcode.com/problems/check-if-any-element-has-prime-frequency/description/
public class S03591
{
    public bool CheckPrimeFrequency(int[] nums)
    {
        var frequencies = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            frequencies[num] = frequencies.GetValueOrDefault(num) + 1;
        }

        return frequencies.Values.Any(IsPrime);
    }
    
    private static bool IsPrime(int n)
    {
        if (n == 2)
        {
            return true;
        }

        if (n < 2 || n % 2 == 0)
        {
            return false;
        }

        for (var i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}