namespace leetcode_sharp;

// 119. Pascal's Triangle II
// https://leetcode.com/problems/pascals-triangle-ii/
public class S00119
{
    public IList<int> GetRow(int rowIndex)
    {
        var result = new int[rowIndex + 1];
        result[0] = 1;
        result[^1] = 1;
        
        for (var k = 1; k <= rowIndex / 2; k++)
        {
            var element = (int)((long)result[k - 1] * (rowIndex + 1 - k) / k);
            result[k] = element;
            result[^(k + 1)] = element;
        }
        
        return result;
    }
}