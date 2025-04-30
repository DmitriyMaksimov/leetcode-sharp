namespace leetcode_sharp;

// 1295. Find Numbers with Even Number of Digits
// https://leetcode.com/problems/find-numbers-with-even-number-of-digits
public class S01295
{
    public int FindNumbers(int[] nums)
    {
        return nums.Count(num => GetLength(num) % 2 == 0);
    }

    private static int GetLength(int num)
    {
        if (num == 0) return 1;

        var count = 0;

        var n = num;
        while (n > 0)
        {
            ++count;
            n /= 10;
        }

        return count;
    }
}
