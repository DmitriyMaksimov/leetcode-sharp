namespace leetcode_sharp;

// 2342. Max Sum of a Pair With Equal Sum of Digits
// https://leetcode.com/problems/max-sum-of-a-pair-with-equal-sum-of-digits
public class S02342
{
    public int MaximumSum(int[] nums)
    {
        var map = new Dictionary<int, int>();
        var result = -1;

        foreach (var item in nums)
        {
            var key = GetDigitsSum(item);

            if (!map.TryGetValue(key, out var value))
            {
                map[key] = item;
            }
            else
            {
                result = Math.Max(result, value + item);
                map[key] = Math.Max(value, item);
            }
        }

        return result;
    }

    private static int GetDigitsSum(int num)
    {
        var result = 0;
        while (num > 0)
        {
            result += num % 10;
            num /= 10;
        }

        return result;
    }
}
