namespace leetcode_sharp;

// 2437. Number of Valid Clock Times
// https://leetcode.com/problems/number-of-valid-clock-times/
public class S02437
{
    public int CountTime(string time)
    {
        var count = 0;
        var hour = time[0] == '?' ? -1 : time[0] - '0';
        var hour2 = time[1] == '?' ? -1 : time[1] - '0';
        var minute = time[3] == '?' ? -1 : time[3] - '0';
        var minute2 = time[4] == '?' ? -1 : time[4] - '0';

        for (var i = 0; i < 24; i++)
        {
            if (hour != -1 && hour != i / 10)
            {
                continue;
            }

            for (var j = 0; j < 60; j++)
            {
                if (hour2 != -1 && hour2 != i % 10)
                {
                    continue;
                }

                if (minute != -1 && minute != j / 10)
                {
                    continue;
                }

                if (minute2 != -1 && minute2 != j % 10)
                {
                    continue;
                }

                count++;
            }
        }

        return count;
    }
}