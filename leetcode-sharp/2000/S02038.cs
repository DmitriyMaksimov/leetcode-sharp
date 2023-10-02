namespace leetcode_sharp;

// 2038. Remove Colored Pieces if Both Neighbors are the Same Color
// https://leetcode.com/problems/remove-colored-pieces-if-both-neighbors-are-the-same-color
public class S02038
{
    public bool WinnerOfGame(string colors)
    {
        var countA = 0;
        var countB = 0;

        for (var i = 0; i < colors.Length; i++)
        {
            var color = colors[i];
            var count = 0;

            while (i < colors.Length && colors[i] == color)
            {
                i++;
                count++;
            }

            switch (color)
            {
                case 'A':
                    countA += Math.Max(count - 2, 0);
                    break;
                case 'B':
                    countB += Math.Max(count - 2, 0);
                    break;
            }

            i--;
        }

        return countA > countB;
    }
}