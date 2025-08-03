using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02475Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02475();
        Assert.That(sut.UnequalTriplets([4, 4, 2, 4, 3]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02475();
        Assert.That(sut.UnequalTriplets([1, 1, 1, 1, 1]), Is.EqualTo(0));
    }
}