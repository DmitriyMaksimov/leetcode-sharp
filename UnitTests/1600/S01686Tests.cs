using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01686Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01686();
        Assert.That(sut.StoneGameVI([1, 3], [2, 1]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01686();
        Assert.That(sut.StoneGameVI([1, 2], [3, 1]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01686();
        Assert.That(sut.StoneGameVI([2, 4, 3], [1, 6, 7]), Is.EqualTo(-1));
    }
}
