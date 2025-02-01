using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00820Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00820();
        Assert.That(sut.MinimumLengthEncoding(["time", "me", "bell"]), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S00820();
        Assert.That(sut.MinimumLengthEncoding(["t"]), Is.EqualTo(2));
    }
}
