namespace leetcode_sharp;

// 4020. Elevator Requests I
// https://leetcode.com/problems/elevator-requests-i
public class S04020
{
    public int ElevatorRequests(int n, int[] requests)
    {
        var currentFloor = 0;
        var result = 0;

        foreach (var request in requests)
        {
            result += Math.Abs(request - currentFloor);
            currentFloor = request;
        }

        return result;
    }
}