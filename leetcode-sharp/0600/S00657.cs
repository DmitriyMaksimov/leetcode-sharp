namespace leetcode_sharp;

// 657. Robot Return to Origin
// https://leetcode.com/problems/robot-return-to-origin/
public class S00657
{
    public bool JudgeCircle(string moves)
    {
        var x = 0;
        var y = 0;

        foreach (var move in moves)
        {
            switch (move)
            {
                case 'D':
                    ++y;
                    break;
                case 'U':
                    --y;
                    break;
                case 'L':
                    --x;
                    break;
                case 'R':
                    ++x;
                    break;
            }
        }
        
        return x == 0 && y == 0;
    }
}