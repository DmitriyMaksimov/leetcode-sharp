using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02767Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02767();
        Assert.That(sut.MinimumBeautifulSubstrings("1011"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02767();
        Assert.That(sut.MinimumBeautifulSubstrings("111"), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02767();
        Assert.That(sut.MinimumBeautifulSubstrings("0"), Is.EqualTo(-1));
    }
}
