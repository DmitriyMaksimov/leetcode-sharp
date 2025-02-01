using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02259Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02259();
        Assert.That(sut.RemoveDigit("123", '3'), Is.EqualTo("12"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02259();
        Assert.That(sut.RemoveDigit("1231", '1'), Is.EqualTo("231"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02259();
        Assert.That(sut.RemoveDigit("551", '5'), Is.EqualTo("51"));
    }
}