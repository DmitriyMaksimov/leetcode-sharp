namespace leetcode_sharp;

// 932. Beautiful Array
// https://leetcode.com/problems/beautiful-array
public class S00932
{
    public int[] BeautifulArray(int n)
    {
        List<int> res = [1];

        while (res.Count < n)
        {
            List<int> tmp = [];
            tmp.AddRange(res.Where(k => k * 2 - 1 <= n).Select(k => k * 2 - 1));
            tmp.AddRange(res.Where(k => k * 2 <= n).Select(k => k * 2));

            res = tmp;
        }

        return res.ToArray();
    }
}
