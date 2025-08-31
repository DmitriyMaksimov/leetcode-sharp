namespace leetcode_sharp;

// 3658. GCD of Odd and Even Sums
// https://leetcode.com/problems/gcd-of-odd-and-even-sums
public class S03658
{
    public int GcdOfOddEvenSums(int n)
    {
        var sum2N = (1 + 2 * n) / 2;
        var sumOdd = (sum2N - n) / 2;
        var sumEven = sum2N - sumOdd;

        return Gcd(sumOdd, sumEven);
    }
    
    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }
}