using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01646Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01646();
        sut.GetMaximumGenerated(7).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01646();
        sut.GetMaximumGenerated(2).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01646();
        sut.GetMaximumGenerated(3).Should().Be(2);
    }
}