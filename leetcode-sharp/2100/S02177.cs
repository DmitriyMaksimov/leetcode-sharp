namespace leetcode_sharp;

// 2177. Find Three Consecutive Integers That Sum to a Given Number
// https://leetcode.com/problems/find-three-consecutive-integers-that-sum-to-a-given-number
public class S02177
{
    public long[] SumOfThree(long num)
    {
        if (num % 3 != 0)
        {
            return [];
        }

        var middle = num / 3;
        return [middle - 1, middle, middle + 1];
    }
}
