namespace leetcode_sharp;

// 731. My Calendar II
// https://leetcode.com/problems/my-calendar-ii
public class S00731
{
    public class MyCalendarTwo
    {
        private readonly List<int[]> _bookings = [];
        private readonly List<int[]> _overlaps = [];

        public bool Book(int start, int end)
        {
            foreach (var booking in _bookings)
            {
                int overlapStart = Math.Max(booking[0], start), overlapEnd = Math.Min(booking[1], end);
                if (overlapStart >= overlapEnd) continue;

                foreach (var overlap in _overlaps)
                {
                    if (Math.Max(overlap[0], overlapStart) < Math.Min(overlap[1], overlapEnd))
                    {
                        _overlaps.Clear();
                        return false;
                    }
                }

                _overlaps.Add([overlapStart, overlapEnd]);
            }

            _bookings.Add([start, end]);
            return true;
        }
    }
}
