using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01358Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01358();
        Assert.That(sut.NumberOfSubstrings("abcabc"), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S01358();
        Assert.That(sut.NumberOfSubstrings("aaacb"), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01358();
        Assert.That(sut.NumberOfSubstrings("abc"), Is.EqualTo(1));
    }
}
