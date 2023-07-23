namespace leetcode_sharp;

// 1601. Maximum Number of Achievable Transfer Requests
// https://leetcode.com/problems/maximum-number-of-achievable-transfer-requests/
public class S01601
{
    private int _result;

    public int MaximumRequests(int n, int[][] requests)
    {
        backTrack(requests, 0, new int[n], 0);
        return _result;
    }

    private void backTrack(int[][] requests, int index, int[] buildings, int num)
    {
        if (index == requests.Length)
        {
            if (buildings.All(i => i == 0))
            {
                // Balanced => update result
                _result = Math.Max(_result, num);
            }

            // We have building with non zero - it's not balanced
            return;
        }

        // We have 2 options:
        // 1. Not Choose the request - go to next index
        backTrack(requests, index + 1, buildings, num);

        // 2. Choose this request
        var request = requests[index];
        var from = request[0];
        var to = request[1];

        buildings[from]++;
        buildings[to]--;
        backTrack(requests, index + 1, buildings, num + 1);
        buildings[from]--;
        buildings[to]++;
    }
}