using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00008))]
public class S00008Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00008();
        Assert.That(sut.MyAtoi("42"), Is.EqualTo(42));
    }

    [Test]
    public void T2()
    {
        var sut = new S00008();
        Assert.That(sut.MyAtoi("-042"), Is.EqualTo(-42));
    }

    [Test]
    public void T3()
    {
        var sut = new S00008();
        Assert.That(sut.MyAtoi("1337c0d3"), Is.EqualTo(1337));
    }
}
