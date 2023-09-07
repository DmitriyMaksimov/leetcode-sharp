using System.Globalization;

namespace leetcode_sharp;

// 1185. Day of the Week
// https://leetcode.com/problems/day-of-the-week/
public class S01185
{
    public string DayOfTheWeek(int day, int month, int year)
    {
        return new DateOnly(year, month, day).ToString("dddd", CultureInfo.InvariantCulture);
    }
}