namespace leetcode_sharp;

// 2120. Execution of All Suffix Instructions Staying in a Grid
// https://leetcode.com/problems/execution-of-all-suffix-instructions-staying-in-a-grid
public class S02120
{
    public int[] ExecuteInstructions(int n, int[] startPos, string s)
    {
        var ans = new int[s.Length];

        for (var i = 0; i < s.Length; i++)
        {
            ans[i] = canMove(startPos[0], startPos[1], i, s, n);
        }

        return ans;
    }

    private static int canMove(int row, int col, int index, string s, int n)
    {
        if (index >= s.Length) return 0;

        return s[index] switch
        {
            'D' => row + 1 >= n ? 0 : canMove(row + 1, col, index + 1, s, n) + 1,
            'U' => row - 1 < 0 ? 0 : canMove(row - 1, col, index + 1, s, n) + 1,
            'L' => col - 1 < 0 ? 0 : canMove(row, col - 1, index + 1, s, n) + 1,
            'R' => col + 1 >= n ? 0 : canMove(row, col + 1, index + 1, s, n) + 1,
            _ => 0
        };
    }
}