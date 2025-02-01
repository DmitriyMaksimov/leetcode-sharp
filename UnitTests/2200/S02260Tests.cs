using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02260Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02260();
        Assert.That(sut.MinimumCardPickup([3, 4, 2, 3, 4, 7]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02260();
        Assert.That(sut.MinimumCardPickup([1, 0, 5, 3]), Is.EqualTo(-1));
    }
}
