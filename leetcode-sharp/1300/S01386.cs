namespace leetcode_sharp;

// 1386. Cinema Seat Allocation
// https://leetcode.com/problems/cinema-seat-allocation
public class S01386
{
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats)
    {
        var result = n * 2;

        var dictionary = new Dictionary<int, int>();

        foreach (var reserved in reservedSeats)
        {
            var reservedSeat = reserved[1];
            if (reservedSeat is <= 1 or >= 10)
            {
                continue;
            }

            var reservedRow = reserved[0];

            dictionary.TryAdd(reservedRow, 0);

            dictionary[reservedRow] |= 1 << (reservedSeat - 2);
        }

        foreach (var (_, seats) in dictionary)
        {
            var left = (seats & 0b11110000) != 0;
            var mid = (seats & 0b00111100) != 0;
            var right = (seats & 0b00001111) != 0;

            result -= left && mid && right ? 2 : 1;
        }

        return result;
    }
}