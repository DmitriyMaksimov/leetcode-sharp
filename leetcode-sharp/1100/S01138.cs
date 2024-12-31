using System.Text;

namespace leetcode_sharp;

// 1138. Alphabet Board Path
// https://leetcode.com/problems/alphabet-board-path
public class S01138
{
    public string AlphabetBoardPath(string target)
    {
        const int gridSize = 5;
        var currentX = 0;
        var currentY = 0;
        var sb = new StringBuilder();

        foreach (var ch in target)
        {
            var targetX = (ch - 'a') % gridSize;
            var targetY = (ch - 'a') / gridSize;

            sb.Append(new string('U', Math.Max(0, currentY - targetY)));
            sb.Append(new string('R', Math.Max(0, targetX - currentX)));
            sb.Append(new string('L', Math.Max(0, currentX - targetX)));
            sb.Append(new string('D', Math.Max(0, targetY - currentY)));

            sb.Append('!');

            currentX = targetX;
            currentY = targetY;
        }

        return sb.ToString();
    }
}
