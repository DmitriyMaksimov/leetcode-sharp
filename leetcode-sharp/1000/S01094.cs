namespace leetcode_sharp;

// 1094. Car Pooling
// https://leetcode.com/problems/car-pooling
public class S01094
{
    public bool CarPooling(int[][] trips, int capacity)
    {
        var events = new List<(int time, int passengers)>();

        foreach (var trip in trips)
        {
            var numPassengers = trip[0];
            var start = trip[1];
            var end = trip[2];

            events.Add((start, numPassengers));
            events.Add((end, -numPassengers));
        }

        events.Sort((a, b) => a.time == b.time ? a.passengers.CompareTo(b.passengers) : a.time.CompareTo(b.time));

        var filled = 0;

        foreach (var evt in events)
        {
            filled += evt.passengers;

            if (filled > capacity)
            {
                return false;
            }
        }

        return true;
    }
}
