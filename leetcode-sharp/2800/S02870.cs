namespace leetcode_sharp;

// 2870. Minimum Number of Operations to Make Array Empty
// https://leetcode.com/problems/minimum-number-of-operations-to-make-array-empty
public class S02870
{
    public int MinOperations(int[] nums)
    {
        var dictionary = createMinOperationsDictionary(nums);
        var result = 0;

        foreach (var item in dictionary)
        {
            if (item.Value == 1) return -1;

            if (item.Value % 3 == 0)
            {
                result += item.Value / 3;
            }
            else
            {
                result += item.Value / 3 + 1;
            }
        }

        return result;
    }

    private static Dictionary<int, int> createMinOperationsDictionary(IReadOnlyList<int> nums)
    {
        var dictionary = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            dictionary[n] = dictionary.GetValueOrDefault(n) + 1;
        }

        return dictionary;
    }
}