using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00647Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00647();
        Assert.That(sut.CountSubstrings("abc"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00647();
        Assert.That(sut.CountSubstrings("aaa"), Is.EqualTo(6));
    }
}