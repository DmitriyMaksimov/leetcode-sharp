namespace leetcode_sharp;

// 79. Word Search
// https://leetcode.com/problems/word-search/
public class S00079
{
    public bool Exist(char[][] board, string word)
    {
        var directions = new[] {0, -1, 0, 1, 0};
        var m = board.Length;
        var n = board[0].Length;
        var wordLength = word.Length;

        for (var i = 0; i < m; ++i)
        {
            for (var j = 0; j < n; ++j)
            {
                if (Dfs(i, j, 0)) return true;
            }
        }

        return false;

        bool Dfs(int i, int j, int currentLetterIndex)
        {
            if (currentLetterIndex == wordLength) return true;

            if (i < 0 || i >= m || j < 0 || j >= n) return false;
            if (board[i][j] != word[currentLetterIndex]) return false;

            board[i][j] = '_';
            for (var d = 0; d < 4; ++d)
                if (Dfs(i + directions[d], j + directions[d + 1], currentLetterIndex + 1))
                    return true;
            board[i][j] = word[currentLetterIndex];

            return false;
        }
    }
}