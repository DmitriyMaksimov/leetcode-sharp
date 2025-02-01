using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02930Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02930();
        Assert.That(sut.StringCount(4), Is.EqualTo(12));
    }

    [Test]
    public void T2()
    {
        var sut = new S02930();
        Assert.That(sut.StringCount(10), Is.EqualTo(83943898));
    }
}
