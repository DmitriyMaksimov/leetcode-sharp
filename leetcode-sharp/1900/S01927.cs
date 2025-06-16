namespace leetcode_sharp;

// 1927. Sum Game
// https://leetcode.com/problems/sum-game
public class S01927
{
    public bool SumGame(string num)
    {
        var diff = 0;
        var left = 0;
        var right = 0;
        var half = num.Length / 2;

        for (var i = 0; i < half; i++)
        {
            if (num[i] == '?')
            {
                left++;
            }
            else
            {
                diff += num[i] - '0';
            }
        }

        for (var i = half; i < num.Length; i++)
        {
            if (num[i] == '?')
            {
                right++;
            }
            else
            {
                diff -= num[i] - '0';
            }
        }

        if ((left + right) % 2 == 1)
        {
            return true;
        }

        if (left == right)
        {
            return diff != 0;
        }

        var round = (left - right) / 2;

        if (diff * round >= 0)
        {
            return true;
        }

        return Math.Abs(diff) != Math.Abs(round * 9);
    }
}