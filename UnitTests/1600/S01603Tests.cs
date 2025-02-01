using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01603Tests
{
    [Test]
    public void T1()
    {
        var parkingSystem = new S01603.ParkingSystem(1, 1, 0);
        Assert.That(parkingSystem.AddCar(1), Is.True); // return true because there is 1 available slot for a big car
        Assert.That(parkingSystem.AddCar(2), Is.True); // return true because there is 1 available slot for a medium car
        Assert.That(parkingSystem.AddCar(3), Is.False); // return false because there is no available slot for a small car
        Assert.That(parkingSystem.AddCar(1), Is.False); // return false because there is no available slot for a big car. It is already occupied.
    }
}
