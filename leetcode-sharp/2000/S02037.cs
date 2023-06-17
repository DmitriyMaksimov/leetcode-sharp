namespace leetcode_sharp;

// 2037. Minimum Number of Moves to Seat Everyone
// https://leetcode.com/problems/minimum-number-of-moves-to-seat-everyone/
public class S02037
{
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        Array.Sort(seats);
        Array.Sort(students);

        return seats.Select((t, i) => Math.Abs(t - students[i])).Sum();
    }
}