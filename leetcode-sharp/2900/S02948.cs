namespace leetcode_sharp;

// 2948. Make Lexicographically Smallest Array by Swapping Elements
// https://leetcode.com/problems/make-lexicographically-smallest-array-by-swapping-elements
public class S02948
{
    public int[] LexicographicallySmallestArray(int[] nums, int limit)
    {
        var n = nums.Length;
        var a = new (int value, int index)[n];

        for (var i = 0; i < n; i++)
        {
            a[i] = (nums[i], i);
        }

        Array.Sort(a, (t1, t2) => t1.value.CompareTo(t2.value));

        var x = new List<int>[n];
        var y = new List<int>[n];

        for (var i = 0; i < n; i++)
        {
            x[i] = [];
            y[i] = [];
        }

        var j = 0;
        var cur = a[0].value;
        x[j].Add(a[0].value);
        y[j].Add(a[0].index);

        for (var i = 1; i < n; i++)
        {
            if (a[i].value - cur > limit)
            {
                j++;
            }

            x[j].Add(a[i].value);
            y[j].Add(a[i].index);
            cur = a[i].value;
        }

        for (var i = 0; i <= j; i++)
        {
            y[i].Sort();
        }

        var result = new int[n];

        for (var i = 0; i <= j; i++)
        {
            for (var k = 0; k < x[i].Count; k++)
            {
                result[y[i][k]] = x[i][k];
            }
        }

        return result;
    }
}
