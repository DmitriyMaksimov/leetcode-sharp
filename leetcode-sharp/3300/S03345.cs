namespace leetcode_sharp;

// 3345. Smallest Divisible Digit Product I
// https://leetcode.com/problems/smallest-divisible-digit-product-i
public class S03345
{
    public int SmallestNumber(int n, int t)
    {
        while (true)
        {
            if (IsProductDivisible(n, t))
            {
                return n;
            }
            n++;
        }
    }

    private static bool IsProductDivisible(int number, int t)
    {
        var product = 1;

        while (number > 0)
        {
            var digit = number % 10;
            product *= digit;
            number /= 10;
        }

        return product % t == 0;
    }
}
