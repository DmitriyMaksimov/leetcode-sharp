using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00664Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00664();
        sut.StrangePrinter("aaabbb").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00664();
        sut.StrangePrinter("aba").Should().Be(2);
    }
}