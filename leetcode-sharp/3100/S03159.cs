namespace leetcode_sharp;

// 3159. Find Occurrences of an Element in an Array
// https://leetcode.com/problems/find-occurrences-of-an-element-in-an-array
public class S03159
{
    public int[] OccurrencesOfElement(int[] nums, int[] queries, int x)
    {
        Dictionary<int, int> dict = [];
        var occurrence = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == x)
            {
                dict.Add(++occurrence, i);
            }
        }

        return queries.Select(index => dict.GetValueOrDefault(index, -1)).ToArray();
    }
}
