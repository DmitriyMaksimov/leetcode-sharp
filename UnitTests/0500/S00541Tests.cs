using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00541Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00541();
        Assert.That(sut.ReverseStr("abcdefg", 2), Is.EqualTo("bacdfeg"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00541();
        Assert.That(sut.ReverseStr("abcd", 2), Is.EqualTo("bacd"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00541();
        Assert.That(sut.ReverseStr("abcd", 4), Is.EqualTo("dcba"));
    }
}