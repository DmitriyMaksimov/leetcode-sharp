namespace leetcode_sharp;

// 1748. Sum of Unique Elements
// https://leetcode.com/problems/sum-of-unique-elements/
public class S01748
{
    public int SumOfUnique(int[] nums)
    {
        var dictionary = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            dictionary[num] = dictionary.GetValueOrDefault(num) + 1;
        }

        return dictionary.Where(x => x.Value == 1).Select(x => x.Key).Sum();
    }
}