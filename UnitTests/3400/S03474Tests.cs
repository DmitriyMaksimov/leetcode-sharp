using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03474))]
public class S03474Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03474();
        Assert.That(sut.GenerateString("TFTF", "ab"), Is.EqualTo("ababa"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03474();
        Assert.That(sut.GenerateString("TFTF", "abc"), Is.EqualTo(""));
    }

    [Test]
    public void T3()
    {
        var sut = new S03474();
        Assert.That(sut.GenerateString("F", "d"), Is.EqualTo("a"));
    }
}