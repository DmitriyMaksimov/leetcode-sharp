namespace leetcode_sharp;

// 1399. Count Largest Group
// https://leetcode.com/problems/count-largest-group/
public class S01399
{
    public int CountLargestGroup(int n)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 1; i <= n; i++)
        {
            var sum = sumOfDigits(i);
            dict[sum] = dict.GetValueOrDefault(sum, 0) + 1;
        }

        var max = dict.Values.Max();
        return dict.Values.Count(x => x == max);
    }

    private static int sumOfDigits(int n)
    {
        var sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }
}