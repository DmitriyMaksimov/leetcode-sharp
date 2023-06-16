namespace leetcode_sharp;

// 1323. Maximum 69 Number
// https://leetcode.com/problems/maximum-69-number/
public class S01323
{
    public int Maximum69Number(int num)
    {
        var n = 10000;

        while (n > 0)
        {
            var currentDigit = (num / n) % 10; 

            if (currentDigit == 6)
            {
                // replace first `6` to `9` and return
                return num + (9 - 6) * n;
            }

            n /= 10;
        }
        
        return num;
    }
}