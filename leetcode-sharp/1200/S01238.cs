namespace leetcode_sharp;

// 1238. Circular Permutation in Binary Representation
// https://leetcode.com/problems/circular-permutation-in-binary-representation
public class S01238
{
    public IList<int> CircularPermutation(int n, int start)
    {
        var grayCode = GetGrayCode(n);
        var startIndex = grayCode.IndexOf(start);
        List<int> res = [];

        for (var i = startIndex; i < grayCode.Count; i++)
        {
            res.Add(grayCode[i]);
        }

        for (var i = 0; i < startIndex; i++)
        {
            res.Add(grayCode[i]);
        }

        return res;
    }

    private List<int> GetGrayCode(int n)
    {
        List<int> grayCode = [0];

        if (n == 0)
        {
            return grayCode;
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = grayCode.Count - 1; j >= 0; j--)
            {
                grayCode.Add(grayCode[j] + (1 << i));
            }
        }

        return grayCode;
    }
}
