using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01742Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01742();
        sut.CountBalls(1, 10).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01742();
        sut.CountBalls(5, 15).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01742();
        sut.CountBalls(19, 28).Should().Be(2);
    }
}