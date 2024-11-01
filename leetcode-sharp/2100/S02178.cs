namespace leetcode_sharp;

// 2178. Maximum Split of Positive Even Integers
// https://leetcode.com/problems/maximum-split-of-positive-even-integers
public class S02178
{
    public IList<long> MaximumEvenSplit(long finalSum)
    {
        if (finalSum % 2 != 0)
        {
            return new List<long>();
        }

        List<long> result = [];
        long i = 2;
        long crSum = 0;

        while (crSum + i <= finalSum)
        {
            result.Add(i);
            crSum += i;
            i += 2;
        }

        if (result.Count > 0)
        {
            result[^1] += finalSum - crSum;
        }

        return result;
    }
}
