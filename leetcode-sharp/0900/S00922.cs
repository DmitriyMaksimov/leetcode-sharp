namespace leetcode_sharp;

// 922. Sort Array By Parity II
// https://leetcode.com/problems/sort-array-by-parity-ii/
public class S00922
{
    public int[] SortArrayByParityII(int[] nums)
    {
        var evenIndex = 0;
        var oddIndex = 1;
        var answer = new int[nums.Length];

        foreach (var n in nums)
        {
            if (n % 2 == 0)
            {
                answer[evenIndex] = n;
                evenIndex += 2;
            }
            else
            {
                answer[oddIndex] = n;
                oddIndex += 2;
            }
        }

        return answer;
    }
}