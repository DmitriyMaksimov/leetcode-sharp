using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01814Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01814();
        Assert.That(sut.CountNicePairs([42, 11, 1, 97]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01814();
        Assert.That(sut.CountNicePairs([13, 10, 35, 24, 76]), Is.EqualTo(4));
    }
}