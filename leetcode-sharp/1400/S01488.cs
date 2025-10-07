namespace leetcode_sharp;

// 1488. Avoid Flood in The City
// https://leetcode.com/problems/avoid-flood-in-the-city
public class S01488
{
    public int[] AvoidFlood(int[] rains)
    {
        var result = Enumerable.Repeat(-1, rains.Length).ToArray();
        var lastRain = new Dictionary<int, int>();
        var dryDays = new SortedSet<int>();

        for (var i = 0; i < rains.Length; i++)
        {
            if (rains[i] == 0)
            {
                dryDays.Add(i);
                result[i] = 1;
            }
            else
            {
                if (lastRain.TryGetValue(rains[i], out var lastIndex))
                {
                    var dryDay = FindNextDryDay(dryDays, lastIndex);
                    if (dryDay == -1)
                    {
                        return [];
                    }

                    result[dryDay] = rains[i];
                    dryDays.Remove(dryDay);
                }

                lastRain[rains[i]] = i;
            }
        }

        return result;
    }

    private static int FindNextDryDay(SortedSet<int> dryDays, int lastIndex)
    {
        foreach (var day in dryDays)
        {
            if (day > lastIndex)
            {
                return day;
            }
        }

        return -1;
    }
}