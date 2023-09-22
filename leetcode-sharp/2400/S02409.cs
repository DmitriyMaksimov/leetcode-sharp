namespace leetcode_sharp;

// 2409. Count Days Spent Together
// https://leetcode.com/problems/count-days-spent-together/
public class S02409
{
    public int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
    {
        var arrive_alice = DateTime.ParseExact(arriveAlice, "MM-dd", null).DayOfYear;
        var leave_alice = DateTime.ParseExact(leaveAlice, "MM-dd", null).DayOfYear;
        var arrive_bob = DateTime.ParseExact(arriveBob, "MM-dd", null).DayOfYear;
        var leave_bob = DateTime.ParseExact(leaveBob, "MM-dd", null).DayOfYear;

        return Math.Max(0, Math.Min(leave_alice, leave_bob) - Math.Max(arrive_alice, arrive_bob) + 1);
    }
}