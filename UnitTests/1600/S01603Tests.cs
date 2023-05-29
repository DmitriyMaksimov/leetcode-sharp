using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01603Tests
{
    [Test]
    public void T1()
    {
        var parkingSystem = new S01603.ParkingSystem(1, 1, 0);
        parkingSystem.AddCar(1).Should().BeTrue(); // return true because there is 1 available slot for a big car
        parkingSystem.AddCar(2).Should().BeTrue(); // return true because there is 1 available slot for a medium car
        parkingSystem.AddCar(3).Should().BeFalse(); // return false because there is no available slot for a small car
        parkingSystem.AddCar(1).Should().BeFalse(); // return false because there is no available slot for a big car. It is already occupied.
    }
}