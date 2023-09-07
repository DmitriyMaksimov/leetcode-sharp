using System.Globalization;

namespace leetcode_sharp;

// 1154. Day of the Year
// https://leetcode.com/problems/day-of-year/
public class S01154
{
    public int DayOfYear(string date)
    {
        return DateOnly.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture).DayOfYear;
    }
}