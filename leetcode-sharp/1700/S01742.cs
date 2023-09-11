namespace leetcode_sharp;

// 1742. Maximum Number of Balls in a Box
// https://leetcode.com/problems/maximum-number-of-balls-in-a-box/
public class S01742
{
    public int CountBalls(int lowLimit, int highLimit)
    {
        var dict = new Dictionary<int, int>();

        for (var i = lowLimit; i <= highLimit; i++)
        {
            var sum = 0;
            var n = i;
        
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            
            dict[sum] = dict.GetValueOrDefault(sum) + 1;
        }

        return dict.Values.Max();
    }
}