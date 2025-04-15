using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02179Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02179();
        Assert.That(sut.GoodTriplets([2, 0, 1, 3], [0, 1, 2, 3]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02179();
        Assert.That(sut.GoodTriplets([4, 0, 1, 3, 2], [4, 1, 0, 2, 3]), Is.EqualTo(4));
    }
}
