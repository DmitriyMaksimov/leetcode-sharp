using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02594Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02594();
        Assert.That(sut.RepairCars([4, 2, 3, 1], 10), Is.EqualTo(16));
    }

    [Test]
    public void T2()
    {
        var sut = new S02594();
        Assert.That(sut.RepairCars([5, 1, 8], 6), Is.EqualTo(16));
    }
}
