namespace leetcode_sharp;

// 2614. Prime In Diagonal
// https://leetcode.com/problems/prime-in-diagonal
public class S02614
{
    public int DiagonalPrime(int[][] nums)
    {
        var result = 0;
        var n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            if (isPrime(nums[i][i]))
            {
                result = Math.Max(result, nums[i][i]);
            }

            if (isPrime(nums[i][n - 1 - i]))
            {
                result = Math.Max(result, nums[i][n - 1 - i]);
            }
        }

        return result;
    }

    private static bool isPrime(int a)
    {
        if (a <= 1) return false;

        for (var i = 2; i <= Math.Sqrt(a); i++)
        {
            if (a % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}