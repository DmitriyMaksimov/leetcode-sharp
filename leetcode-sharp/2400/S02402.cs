namespace leetcode_sharp;

// 2402. Meeting Rooms III
// https://leetcode.com/problems/meeting-rooms-iii
public class S02402
{
    public int MostBooked(int n, int[][] meetings)
    {
        var rooms = new long[n];
        var count = new int[n];
        
        foreach (var meeting in meetings.OrderBy(x => x[0]))
        {
            var meetingStart = meeting[0];
            var meetingEnd = meeting[1];
            var bestIndex = long.MinValue;
            var bestEnd = long.MaxValue;

            var flag = false;
            
            for (var i = 0; i < rooms.Length; i++)
            {
                var end = rooms[i];
                if (meetingStart >= end)
                {
                    rooms[i] = meetingEnd;
                    count[i] += 1;
                    flag = true;
                    break;
                }

                if (end < bestEnd)
                {
                    bestIndex = i;
                    bestEnd = end;
                }
            }

            if (!flag)
            {
                rooms[bestIndex] = meetingEnd - meetingStart + rooms[bestIndex];
                count[bestIndex] += 1;
            }
        }

        return Array.IndexOf(count, count.Max());
    }
}