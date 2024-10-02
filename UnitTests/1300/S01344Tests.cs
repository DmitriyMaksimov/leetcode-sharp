using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01344Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01344();
        sut.AngleClock(12, 30).Should().Be(165);
    }

    [Test]
    public void T2()
    {
        var sut = new S01344();
        sut.AngleClock(3, 30).Should().Be(75);
    }

    [Test]
    public void T3()
    {
        var sut = new S01344();
        sut.AngleClock(3, 15).Should().Be(7.5);
    }
}
