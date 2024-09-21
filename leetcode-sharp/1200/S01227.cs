namespace leetcode_sharp;

// 1227. Airplane Seat Assignment Probability
// https://leetcode.com/problems/airplane-seat-assignment-probability
public class S01227
{
    public double NthPersonGetsNthSeat(int n)
    {
        return n == 1 ? 1.0 : 0.5;
    }
}
