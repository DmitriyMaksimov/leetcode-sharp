namespace leetcode_sharp;

// 1952. Three Divisors
// https://leetcode.com/problems/three-divisors/
public class S01952
{
    public bool IsThree(int n)
    {
        if (n <= 2) return false; 

        var count = 1;

        for (var i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }

        return count == 2;
    }
}