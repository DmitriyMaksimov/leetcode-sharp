namespace leetcode_sharp;

// 2894. Divisible and Non-divisible Sums Difference
// https://leetcode.com/problems/divisible-and-non-divisible-sums-difference
public class S02894
{
    public int DifferenceOfSums(int n, int m)
    {
        var num1 = 0;
        var num2 = 0;
        
        for (var i = 1; i <= n; i++)
        {
            if (i % m != 0)
            {
                num1 += i;
            }
            else
            {
                num2 += i;
            }
        }

        return num1 - num2;
    }
}