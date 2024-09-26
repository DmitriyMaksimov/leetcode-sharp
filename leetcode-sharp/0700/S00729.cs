namespace leetcode_sharp;

// 729. My Calendar I
// https://leetcode.com/problems/my-calendar-i
public static class S00729
{
public class MyCalendar
{
    private readonly SortedSet<Event> _events = [];

    public bool Book(int start, int end)
    {
        return _events.Add(new Event(start, end));
    }

    private class Event : IComparable<Event>
    {
        private int Start { get; }
        private int End { get; }

        public Event(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int CompareTo(Event? other)
        {
            if (End <= other!.Start)
            {
                return -1;
            }

            return Start >= other.End ? 1 : 0;
        }
    }
}
}
