namespace leetcode_sharp;

// 2657. Find the Prefix Common Array of Two Arrays
// https://leetcode.com/problems/find-the-prefix-common-array-of-two-arrays
public class S02657
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        HashSet<int> setA = [];
        HashSet<int> setB = [];
        var result = new int[A.Length];
        var count = 0;

        for (var i = 0; i < B.Length; i++)
        {
            if (A[i] == B[i])
            {
                ++count;
            }
            else
            {
                setA.Add(A[i]);
                setB.Add(B[i]);
            }

            if (setA.Contains(B[i]))
            {
                ++count;
            }

            if (setB.Contains(A[i]))
            {
                ++count;
            }

            result[i] = count;
        }

        return result;
    }
}