namespace leetcode_sharp;

// 3158. Find the XOR of Numbers Which Appear Twice
// https://leetcode.com/problems/find-the-xor-of-numbers-which-appear-twice
public class S03158
{
    public int DuplicateNumbersXOR(int[] nums)
    {
        Dictionary<int, int> frequencies = [];

        foreach (var num in nums)
        {
            frequencies[num] = frequencies.GetValueOrDefault(num) + 1;
        }

        return frequencies.Where(x => x.Value == 2).Select(x => x.Key).Aggregate(0, (current, num) => current ^ num);
    }
}