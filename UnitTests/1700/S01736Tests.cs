using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01736Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01736();
        sut.MaximumTime("2?:?0").Should().Be("23:50");
    }

    [Test]
    public void T2()
    {
        var sut = new S01736();
        sut.MaximumTime("0?:3?").Should().Be("09:39");
    }

    [Test]
    public void T3()
    {
        var sut = new S01736();
        sut.MaximumTime("1?:22").Should().Be("19:22");
    }
}