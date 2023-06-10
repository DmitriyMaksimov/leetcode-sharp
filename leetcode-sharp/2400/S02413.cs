namespace leetcode_sharp;

// 2413. Smallest Even Multiple
// https://leetcode.com/problems/smallest-even-multiple/
public class S02413
{
    public int SmallestEvenMultiple(int n)
    {
        return n % 2 == 0 ? n : n * 2;
    }
}