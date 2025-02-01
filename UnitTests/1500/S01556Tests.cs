using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01556Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01556();
        Assert.That(sut.ThousandSeparator(987), Is.EqualTo("987"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01556();
        Assert.That(sut.ThousandSeparator(1234), Is.EqualTo("1.234"));
    }
}