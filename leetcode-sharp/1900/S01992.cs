namespace leetcode_sharp;

// 1992. Find All Groups of Farmland
// https://leetcode.com/problems/find-all-groups-of-farmland/
public class S01992
{
    public int[][] FindFarmland(int[][] land)
    {
        List<int[]> resultList = [];

        for (var i = 0; i < land.Length; i++)
        {
            for (var j = 0; j < land[0].Length; j++)
            {
                if (land[i][j] != 1 || (i != 0 && land[i - 1][j] != 0) || (j != 0 && land[i][j - 1] != 0)) continue;

                var i2 = i;
                var j2 = j;

                while (i2 < land.Length && land[i2][j] == 1)
                {
                    i2++;
                }

                while (j2 < land[0].Length && land[i][j2] == 1)
                {
                    j2++;
                }

                resultList.Add([i, j, i2 - 1, j2 - 1]);
            }
        }

        return resultList.ToArray();
    }
}