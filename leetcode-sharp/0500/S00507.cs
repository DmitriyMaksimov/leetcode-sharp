namespace leetcode_sharp;

// 507. Perfect Number
// https://leetcode.com/problems/perfect-number/
public class S00507
{
    public bool CheckPerfectNumber(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        var sum = 1;
        var sqrt = (int) Math.Sqrt(num);

        for (var i = 2; i <= sqrt; i++)
        {
            if (num % i != 0) continue;
            
            sum += i + num / i;
        }

        return sum == num;
    }
}