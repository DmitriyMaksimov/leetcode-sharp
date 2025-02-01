using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00664Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00664();
        Assert.That(sut.StrangePrinter("aaabbb"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00664();
        Assert.That(sut.StrangePrinter("aba"), Is.EqualTo(2));
    }
}