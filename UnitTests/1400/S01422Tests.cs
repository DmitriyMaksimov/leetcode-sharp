using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01422Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01422();
        sut.MaxScore("011101").Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01422();
        sut.MaxScore("00111").Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S01422();
        sut.MaxScore("1111").Should().Be(3);
    }
}