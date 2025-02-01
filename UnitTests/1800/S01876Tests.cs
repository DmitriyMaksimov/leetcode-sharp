using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01876Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01876();
        Assert.That(sut.CountGoodSubstrings("xyzzaz"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01876();
        Assert.That(sut.CountGoodSubstrings("aababcabc"), Is.EqualTo(4));
    }
}