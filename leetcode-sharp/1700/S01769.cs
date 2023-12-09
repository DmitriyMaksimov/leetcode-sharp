namespace leetcode_sharp;

// 1769. Minimum Number of Operations to Move All Balls to Each Box
// https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box
public class S01769
{
    public int[] MinOperations(string boxes)
    {
        var res = new int[boxes.Length];

        for (var i = 0; i < boxes.Length; i++)
        {
            var sum = 0;
        
            for (var j = 0; j < boxes.Length; j++)
            {
                if (i == j) continue;
                if (boxes[j] == '1')
                    sum += Math.Abs(i - j);
            }

            res[i] = sum;
        }

        return res;
    }
}