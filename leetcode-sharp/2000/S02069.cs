namespace leetcode_sharp;

// 2069. Walking Robot Simulation II
// https://leetcode.com/problems/walking-robot-simulation-ii
public class S02069
{
    public class Robot(int width, int height)
    {
        private int _x;
        private int _y;
        private Direction _direction = Direction.East;

        private enum Direction
        {
            East,
            North,
            West,
            South
        }

        public void Step(int num)
        {
            var perimeter = 2 * (width - 1) + 2 * (height - 1);
            num %= perimeter;
            if (num == 0)
            {
                num = perimeter;
            }

            while (num > 0)
            {
                switch (_direction)
                {
                    case Direction.East:
                    {
                        var maxX = Math.Min(_x + num, width - 1);
                        var rem = num - (maxX - _x);
                        num = rem;

                        _x = maxX;

                        if (rem != 0)
                        {
                            _direction = Direction.North;
                        }

                        break;
                    }

                    case Direction.West:
                    {
                        var minX = Math.Max(_x - num, 0);
                        var rem = num - (_x - minX);
                        num = rem;

                        _x = minX;
                        if (rem != 0)
                        {
                            _direction = Direction.South;
                        }

                        break;
                    }

                    case Direction.North:
                    {
                        var maxY = Math.Min(_y + num, height - 1);
                        var rem = num - (maxY - _y);
                        num = rem;

                        _y = maxY;
                        if (rem != 0)
                        {
                            _direction = Direction.West;
                        }

                        break;
                    }

                    case Direction.South:
                    {
                        var minY = Math.Max(_y - num, 0);
                        var rem = num - (_y - minY);
                        num = rem;

                        _y = minY;
                        if (rem != 0)
                        {
                            _direction = Direction.East;
                        }

                        break;
                    }
                }
            }
        }

        public int[] GetPos() => [_x, _y];

        public string GetDir() => _direction.ToString();
    }
}