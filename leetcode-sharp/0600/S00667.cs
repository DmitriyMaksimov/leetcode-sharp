namespace leetcode_sharp;

// 667. Beautiful Arrangement II
// https://leetcode.com/problems/beautiful-arrangement-ii
public class S00667
{
    public int[] ConstructArray(int n, int k)
    {
        var result = new int[n];

        for (int i = 0, l = 1, r = n; l <= r; i++)
        {
            result[i] = k > 1 ? k-- % 2 != 0 ? l++ : r-- : l++;
        }

        return result;
    }
}
