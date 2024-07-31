namespace leetcode_sharp;

// 1105. Filling Bookcase Shelves
// https://leetcode.com/problems/filling-bookcase-shelves
public class S01105
{
    public int MinHeightShelves(int[][] books, int shelfWidth)
    {
        var dp = new int[books.Length + 1];

        dp[0] = 0;

        for (var i = 1; i <= books.Length; ++i)
        {
            var width = books[i - 1][0];
            var height = books[i - 1][1];

            dp[i] = dp[i - 1] + height;

            for (var j = i - 1; j > 0 && width + books[j - 1][0] <= shelfWidth; --j)
            {
                height = Math.Max(height, books[j - 1][1]);
                width += books[j - 1][0];
                dp[i] = Math.Min(dp[i], dp[j - 1] + height);
            }
        }

        return dp[books.Length];
    }
}
