namespace leetcode_sharp;

// 1184. Distance Between Bus Stops
// https://leetcode.com/problems/distance-between-bus-stops/
public class S01184
{
    public int DistanceBetweenBusStops(int[] distance, int start, int destination)
    {
        var totalDistance = 0;
        var distanceFromStart = 0;

        for (var i = 0; i < distance.Length; i++)
        {
            totalDistance += distance[i];

            if (i >= start && i < destination || i >= destination && i < start)
            {
                distanceFromStart += distance[i];
            }
        }

        return Math.Min(distanceFromStart, totalDistance - distanceFromStart);
    }
}