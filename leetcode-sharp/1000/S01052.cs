namespace leetcode_sharp;

// 1052. Grumpy Bookstore Owner
// https://leetcode.com/problems/grumpy-bookstore-owner
public class S01052
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        var satisfied = 0;
        var maxMakeSatisfied = 0;

        for (int i = 0, winOfMakeSatisfied = 0; i < grumpy.Length; ++i)
        {
            if (grumpy[i] == 0)
            {
                satisfied += customers[i];
            }
            else
            {
                winOfMakeSatisfied += customers[i];
            }

            if (i >= minutes)
            {
                winOfMakeSatisfied -= grumpy[i - minutes] * customers[i - minutes];
            }

            maxMakeSatisfied = Math.Max(winOfMakeSatisfied, maxMakeSatisfied);
        }

        return satisfied + maxMakeSatisfied;
    }
}