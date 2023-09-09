namespace leetcode_sharp;

// 1360. Number of Days Between Two Dates
// https://leetcode.com/problems/number-of-days-between-two-dates/
public class S01360
{
    public int DaysBetweenDates(string date1, string date2)
    {
        return Math.Abs((DateTime.Parse(date1) - DateTime.Parse(date2)).Days);
    }
}