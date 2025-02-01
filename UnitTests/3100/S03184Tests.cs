using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03184Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03184();
        Assert.That(sut.CountCompleteDayPairs([12, 12, 30, 24, 24]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03184();
        Assert.That(sut.CountCompleteDayPairs([72, 48, 24, 3]), Is.EqualTo(3));
    }
}