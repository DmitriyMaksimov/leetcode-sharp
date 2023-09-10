namespace leetcode_sharp;

// 1640. Check Array Formation Through Concatenation
// https://leetcode.com/problems/check-array-formation-through-concatenation/
public class S01640
{
    public bool CanFormArray(int[] arr, int[][] pieces)
    {
        var map = new Dictionary<int, int[]>();

        foreach (var piece in pieces)
        {
            map[piece[0]] = piece;
        }

        for (var i = 0; i < arr.Length;)
        {
            if (!map.ContainsKey(arr[i]))
            {
                return false;
            }

            var piece = map[arr[i]];
            foreach (var num in piece)
            {
                if (num != arr[i])
                {
                    return false;
                }

                i++;
            }
        }

        return true;
    }
}