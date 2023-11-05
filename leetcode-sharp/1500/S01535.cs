namespace leetcode_sharp;

// 1535. Find the Winner of an Array Game
// https://leetcode.com/problems/find-the-winner-of-an-array-game
public class S01535
{
    public int GetWinner(int[] arr, int k)
    {
        if (k == 1)
        {
            return Math.Max(arr[0], arr[1]);
        }

        if (k >= arr.Length)
        {
            return arr.Max();
        }

        var currentWinner = arr[0];
        var consecutiveWins = 0;

        for (var i = 1; i < arr.Length; i++)
        {
            if (currentWinner > arr[i])
            {
                consecutiveWins++;
            }
            else
            {
                currentWinner = arr[i];
                consecutiveWins = 1;
            }

            if (consecutiveWins == k)
            {
                return currentWinner;
            }
        }

        return currentWinner;
    }
}