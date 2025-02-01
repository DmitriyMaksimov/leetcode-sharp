using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01663Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01663();
        Assert.That(sut.GetSmallestString(3, 27), Is.EqualTo("aay"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01663();
        Assert.That(sut.GetSmallestString(5, 73), Is.EqualTo("aaszz"));
    }
}
