using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00402Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00402();
        Assert.That(sut.RemoveKdigits("1432219", 3), Is.EqualTo("1219"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00402();
        Assert.That(sut.RemoveKdigits("10200", 1), Is.EqualTo("200"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00402();
        Assert.That(sut.RemoveKdigits("10", 2), Is.EqualTo("0"));
    }
}