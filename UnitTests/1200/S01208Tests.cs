using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01208Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01208();
        Assert.That(sut.EqualSubstring("abcd", "bcdf", 3), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01208();
        Assert.That(sut.EqualSubstring("abcd", "cdef", 3), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01208();
        Assert.That(sut.EqualSubstring("abcd", "acde", 0), Is.EqualTo(1));
    }
}