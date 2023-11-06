namespace leetcode_sharp;

// 1845. Seat Reservation Manager
// https://leetcode.com/problems/seat-reservation-manager
public static class S01845
{
    public class SeatManager
    {
        private int _largestReserved = 0;
        private readonly SortedSet<int> _sortedSet = new();
        
        public SeatManager(int n)
        {
        }

        public int Reserve()
        {
            if (!_sortedSet.Any())
            {
                return ++_largestReserved;
            }

            var seat = _sortedSet.Min;
            _sortedSet.Remove(seat);
            return seat;
        }

        public void Unreserve(int seatNumber)
        {
            if (seatNumber == _largestReserved)
            {
                --_largestReserved;
            }
            else
            {
                _sortedSet.Add(seatNumber);
            }
        }
    }
}