namespace leetcode_sharp;

// 1603. Design Parking System
// https://leetcode.com/problems/design-parking-system/
public class S01603
{
    public class ParkingSystem
    {
        private readonly int[] _spacesLeft = new int[3];

        public ParkingSystem(int big, int medium, int small)
        {
            _spacesLeft[0] = big;
            _spacesLeft[1] = medium;
            _spacesLeft[2] = small;
        }

        public bool AddCar(int carType)
        {
            return _spacesLeft[carType - 1]-- > 0;
        }
    }
}