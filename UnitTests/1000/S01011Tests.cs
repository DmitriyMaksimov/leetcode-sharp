using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01011Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01011();
        Assert.That(sut.ShipWithinDays(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 5), Is.EqualTo(15));
    }

    [Test]
    public void T2()
    {
        var sut = new S01011();
        Assert.That(sut.ShipWithinDays(new[] {3, 2, 2, 4, 1, 4}, 3), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S01011();
        Assert.That(sut.ShipWithinDays(new[] {1, 2, 3, 1, 1}, 4), Is.EqualTo(3));
    }
}