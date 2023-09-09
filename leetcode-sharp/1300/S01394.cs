namespace leetcode_sharp;

// 
// https://leetcode.com/problems/find-lucky-integer-in-an-array/
public class S01394
{
    public int FindLucky(int[] arr)
    {
        var dict = new Dictionary<int, int>();

        foreach (var i in arr)
        {
            dict[i] = dict.GetValueOrDefault(i) + 1;
        }

        var max = -1;
        foreach (var (key, value) in dict)
        {
            if (key == value && key > max)
            {
                max = key;
            }
        }

        return max;
    }
}