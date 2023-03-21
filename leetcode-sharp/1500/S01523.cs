namespace leetcode_sharp;

// 1523. Count Odd Numbers in an Interval Range
// https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/
public class S01523
{
    public int CountOdds(int low, int high)
    {
        var interval = high - low + 1;
        if (interval % 2 == 0 || low % 2 == 0 || high % 2 == 0)
        {
            return interval / 2;
        }

        return interval / 2 + 1;
    }
}