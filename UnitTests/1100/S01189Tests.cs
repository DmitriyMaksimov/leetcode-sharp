using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01189Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01189();
        sut.MaxNumberOfBalloons("nlaebolko").Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01189();
        sut.MaxNumberOfBalloons("loonbalxballpoon").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01189();
        sut.MaxNumberOfBalloons("leetcode").Should().Be(0);
    }
}