namespace leetcode_sharp;

// 1337. The K Weakest Rows in a Matrix
// https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/
public class S01337
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        var data = new (int count, int index)[mat.Length];

        for (var index = 0; index < mat.Length; index++)
        {
            var row = mat[index];
            data[index] = (row.TakeWhile(x => x == 1).Count(), index);
        }

        return data.OrderBy(x => x.count).ThenBy(x => x.index).Take(k).Select(x => x.index).ToArray();
    }
}