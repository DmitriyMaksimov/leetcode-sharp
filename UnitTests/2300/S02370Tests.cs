using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02370Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02370();
        Assert.That(sut.LongestIdealString("acfgbd", 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02370();
        Assert.That(sut.LongestIdealString("abcd", 3), Is.EqualTo(4));
    }
}