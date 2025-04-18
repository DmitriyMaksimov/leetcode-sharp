using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01405Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01405();
        Assert.That(sut.LongestDiverseString(1, 1, 7), Is.EqualTo("ccaccbcc"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01405();
        Assert.That(sut.LongestDiverseString(7, 1, 0), Is.EqualTo("aabaa"));
    }
}
