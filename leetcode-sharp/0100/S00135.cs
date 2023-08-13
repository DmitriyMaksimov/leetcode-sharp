namespace leetcode_sharp;

// 135. Candy
// https://leetcode.com/problems/candy/
public class S00135
{
    public int Candy(int[] ratings)
    {
        var n = ratings.Length;
        if (n <= 1)
        {
            return n;
        }

        var num = Enumerable.Repeat(1, n).ToArray();

        for (var i = 1; i < n; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                num[i] = num[i - 1] + 1;
            }
        }

        for (var i = n - 1; i > 0; i--)
        {
            if (ratings[i - 1] > ratings[i])
            {
                num[i - 1] = Math.Max(num[i] + 1, num[i - 1]);
            }
        }

        return num.Sum();
    }
}