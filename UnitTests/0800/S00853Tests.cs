using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00853Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00853();
        Assert.That(sut.CarFleet(12, [10, 8, 0, 5, 3], [2, 4, 1, 1, 3]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00853();
        Assert.That(sut.CarFleet(10, [3], [3]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00853();
        Assert.That(sut.CarFleet(100, [0, 2, 4], [4, 2, 1]), Is.EqualTo(1));
    }
}
