namespace leetcode_sharp;

// 1414. Find the Minimum Number of Fibonacci Numbers Whose Sum Is K
// https://leetcode.com/problems/find-the-minimum-number-of-fibonacci-numbers-whose-sum-is-k
public class S01414
{
    public int FindMinFibonacciNumbers(int k)
    {
        if (k < 2)
        {
            return k;
        }

        var a = 1;
        var b = 1;

        while (b <= k)
        {
            b += a;
            a = b - a;
        }

        return 1 + FindMinFibonacciNumbers(k - a);
    }
}
