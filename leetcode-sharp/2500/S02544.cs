namespace leetcode_sharp;

// 2544. Alternating Digit Sum
// https://leetcode.com/problems/alternating-digit-sum
public class S02544
{
    public int AlternateDigitSum(int n)
    {
        var sum = 0;
        var shouldNegate = false;
        var div = (int)Math.Pow(10, n.ToString().Length - 1);

        while (n > 0)
        {
            var digit = n / div;
            n %= div;
            div /= 10;
            sum += shouldNegate ? -digit : digit;
            shouldNegate = !shouldNegate;
        }
        
        return sum;
    }
}