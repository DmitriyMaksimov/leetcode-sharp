namespace leetcode_sharp;

// 650. 2 Keys Keyboard
// https://leetcode.com/problems/2-keys-keyboard
public class S00650
{
    public int MinSteps(int n)
    {
        var result = 0;

        for (var i = 2; i <= n; i++)
        {
            while (n % i == 0)
            {
                result += i;
                n /= i;
            }
        }

        return result;
    }
}
