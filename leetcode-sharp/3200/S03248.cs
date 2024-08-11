namespace leetcode_sharp;

// 3248. Snake in Matrix
// https://leetcode.com/problems/snake-in-matrix
public class S03248
{
    public int FinalPositionOfSnake(int n, IList<string> commands)
    {
        var position = 0;

        foreach (var command in commands)
        {
            switch (command)
            {
                case "UP":
                    position -= n;
                    break;
                case "DOWN":
                    position += n;
                    break;
                case "LEFT":
                    position--;
                    break;
                case "RIGHT":
                    position++;
                    break;

            }
        }

        return position;
    }
}
