namespace leetcode_sharp;

// 3622. Check Divisibility by Digit Sum and Product
// https://leetcode.com/problems/check-divisibility-by-digit-sum-and-product
public class S03622
{
    public bool CheckDivisibility(int n)
    {
        return n % CalcDivider(n) == 0;
    }
    
    private static int CalcDivider(int n)
    {
        var sum = 0;
        var product = 1;

        while (n > 0)
        {
            sum += n % 10;
            product *= n % 10;
            n /= 10;
        }

        return sum + product;
    }
}