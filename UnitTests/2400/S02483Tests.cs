using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02483Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02483();
        sut.BestClosingTime("YYNY").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02483();
        sut.BestClosingTime("NNNNN").Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S02483();
        sut.BestClosingTime("YYYY").Should().Be(4);
    }
}