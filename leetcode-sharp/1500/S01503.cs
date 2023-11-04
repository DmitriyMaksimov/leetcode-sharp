namespace leetcode_sharp;

// 1503. Last Moment Before All Ants Fall Out of a Plank
// https://leetcode.com/problems/last-moment-before-all-ants-fall-out-of-a-plank
public class S01503
{
    public int GetLastMoment(int n, int[] left, int[] right)
    {
        return right.Select(i => n - i).Prepend(left.Prepend(0).Max()).Max();
    }
}