namespace leetcode_sharp;

// 2520. Count the Digits That Divide a Number
// https://leetcode.com/problems/count-the-digits-that-divide-a-number/
public class S02520
{
    public int CountDigits(int num)
    {
        var count = 0;
        var n = num;

        while (n > 0)
        {
            var lastDigit = n % 10;
            n /= 10;
            if (num % lastDigit == 0)
            {
                ++count;
            }
        }
        
        return count;
    }
}