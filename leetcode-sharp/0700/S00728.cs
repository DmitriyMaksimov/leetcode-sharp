namespace leetcode_sharp;

// 728. Self Dividing Numbers
// https://leetcode.com/problems/self-dividing-numbers/
public class S00728
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        return Enumerable.Range(left, right - left + 1).Where(isSelfDividing).ToArray();
    }

    private static bool isSelfDividing(int num)
    {
        var n = num;

        while (n > 0)
        {
            var digit = n % 10;

            if (digit == 0 || num % digit != 0)
            {
                return false;
            }

            n /= 10;
        }

        return true;
    }
}