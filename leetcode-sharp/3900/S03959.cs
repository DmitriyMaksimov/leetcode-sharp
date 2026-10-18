namespace leetcode_sharp;

// 3959. Check Good Integer
// https://leetcode.com/problems/check-good-integer
public class S03959
{
    public bool CheckGoodInteger(int n)
    {
        var digitSum = 0;
        var squareSum = 0;

        while (n > 0)
        {
            digitSum += n % 10;
            squareSum += (n % 10) * (n % 10);
            n /= 10;
        }
        
        return (squareSum - digitSum) >= 50;
    }
}