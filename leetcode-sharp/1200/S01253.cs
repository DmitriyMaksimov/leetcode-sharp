namespace leetcode_sharp;

// 1253. Reconstruct a 2-Row Binary Matrix
// https://leetcode.com/problems/reconstruct-a-2-row-binary-matrix/description/
public class S01253
{
    public IList<IList<int>> ReconstructMatrix(int upper, int lower, int[] colsum)
    {
        var n = colsum.Length;
        var upperList = new int[n];
        var lowerList = new int[n];

        for (var i = 0; i < n; i++)
        {
            var v = colsum[i];
            switch (v)
            {
                case 2:
                    upperList[i] = 1;
                    lowerList[i] = 1;
                    upper--;
                    lower--;
                    break;
                case 1 when upper > lower:
                    upperList[i] = 1;
                    upper--;
                    break;
                case 1:
                    lowerList[i] = 1;
                    lower--;
                    break;
            }
        }

        if (upper == 0 && lower == 0)
        {
            return new List<IList<int>> { upperList, lowerList };
        }

        return new List<IList<int>>();
    }
}