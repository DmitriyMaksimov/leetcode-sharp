namespace leetcode_sharp;

// 89. Gray Code
// https://leetcode.com/problems/gray-code
public class S00089
{
    public IList<int> GrayCode(int n)
    {
        return Enumerable.Range(0, 1 << n).Select(i => i ^ i >> 1).ToList();
    }
}
