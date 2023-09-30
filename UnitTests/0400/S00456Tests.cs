using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00456Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00456();
        sut.Find132pattern(new[] {1, 2, 3, 4}).Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var sut = new S00456();
        sut.Find132pattern(new[] {3, 1, 4, 2}).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S00456();
        sut.Find132pattern(new[] {-1, 3, 2, 0}).Should().BeTrue();
    }
}