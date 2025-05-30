using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00407Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00407();
        Assert.That(sut.TrapRainWater([[1, 4, 3, 1, 3, 2], [3, 2, 1, 3, 2, 4], [2, 3, 3, 2, 3, 1]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00407();
        Assert.That(sut.TrapRainWater([[3, 3, 3, 3, 3], [3, 2, 2, 2, 3], [3, 2, 1, 2, 3], [3, 2, 2, 2, 3], [3, 3, 3, 3, 3]]), Is.EqualTo(10));
    }

    [Test]
    public void T3()
    {
        var sut = new S00407();
        Assert.That(sut.TrapRainWater([[12, 13, 1, 12], [13, 4, 13, 12], [13, 8, 10, 12], [12, 13, 12, 12], [13, 13, 13, 13]]), Is.EqualTo(14));
    }
}
