using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00521Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00521();
        Assert.That(sut.FindLUSlength("aba", "cdc"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00521();
        Assert.That(sut.FindLUSlength("aaa", "bbb"), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S00521();
        Assert.That(sut.FindLUSlength("aaa", "aaa"), Is.EqualTo(-1));
    }
}