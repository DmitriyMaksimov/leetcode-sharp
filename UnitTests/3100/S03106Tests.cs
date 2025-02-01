using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03106Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03106();
        Assert.That(sut.GetSmallestString("zbbz", 3), Is.EqualTo("aaaz"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03106();
        Assert.That(sut.GetSmallestString("xaxcd", 4), Is.EqualTo("aawcd"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03106();
        Assert.That(sut.GetSmallestString("lol", 0), Is.EqualTo("lol"));
    }
}
