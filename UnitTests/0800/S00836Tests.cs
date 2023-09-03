using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00836Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00836();
        sut.IsRectangleOverlap(new[] {0, 0, 2, 2}, new[] {1, 1, 3, 3}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00836();
        sut.IsRectangleOverlap(new[] {0, 0, 1, 1}, new[] {1, 0, 2, 1}).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00836();
        sut.IsRectangleOverlap(new[] {0, 0, 1, 1}, new[] {2, 2, 3, 3}).Should().BeFalse();
    }
}