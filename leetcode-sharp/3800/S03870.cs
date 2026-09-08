namespace leetcode_sharp;

// 3870. Count Commas in Range
// https://leetcode.com/problems/count-commas-in-range
public class S03870
{
    public int CountCommas(int n)
    {
        return n < 1000 ? 0 : n - 999;
    }
}