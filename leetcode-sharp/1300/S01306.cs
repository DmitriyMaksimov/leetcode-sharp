namespace leetcode_sharp;

// 1306. Jump Game III
// https://leetcode.com/problems/jump-game-iii
public class S01306
{
    public bool CanReach(int[] arr, int start)
    {
        return 0 <= start
            && start < arr.Length
            && arr[start] >= 0
            && (
                (arr[start] = -arr[start]) == 0
                || CanReach(arr, start + arr[start])
                || CanReach(arr, start - arr[start])
            );
    }
}
