namespace leetcode_sharp;

// 3099. Harshad Number
// https://leetcode.com/problems/harshad-number
public class S03099
{
    public int SumOfTheDigitsOfHarshadNumber(int x)
    {
        var sum = 0;
        var n = x;
        
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return x % sum == 0 ? sum : -1;
    }
}