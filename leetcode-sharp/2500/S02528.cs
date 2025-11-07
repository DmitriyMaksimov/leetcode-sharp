namespace leetcode_sharp;

// 2528. Maximize the Minimum Powered City
// https://leetcode.com/problems/maximize-the-minimum-powered-city
public class S02528
{
    public long MaxPower(int[] stations, int r, int k)
    {
        var n = stations.Length;
        var stationPower = new long[n + 1];

        for (var i = 0; i < n; i++)
        {
            var leftBound = Math.Max(i - r, 0);
            var rightBound = Math.Min(i + r, n - 1);

            stationPower[leftBound] += stations[i];
            stationPower[rightBound + 1] -= stations[i];
        }

        for (var i = 1; i < n; i++)
        {
            stationPower[i] += stationPower[i - 1];
        }

        var low = 0L;
        var high = long.MaxValue;
        var result = 0L;

        while (low <= high)
        {
            var targetPower = low + (high - low) / 2;
            var additionalPower = new long[n + 1];
            long remainingStations = k;

            var possible = true;

            for (var i = 0; i < n; i++)
            {
                if (i > 0)
                {
                    additionalPower[i] += additionalPower[i - 1];
                }

                var currentPower = stationPower[i] + additionalPower[i];

                if (currentPower < targetPower)
                {
                    var required = targetPower - currentPower;
                    remainingStations -= required;
                    if (remainingStations < 0)
                    {
                        possible = false;
                        break;
                    }

                    var addUntil = Math.Min(i + r + r, n - 1);
                    additionalPower[i] += required;
                    additionalPower[addUntil + 1] -= required;
                }
            }

            if (possible)
            {
                result = targetPower;
                low = targetPower + 1;
            }
            else
            {
                high = targetPower - 1;
            }
        }

        return result;
    }
}