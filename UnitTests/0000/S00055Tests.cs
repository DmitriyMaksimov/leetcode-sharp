using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00055Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00055();
        sut.CanJump(new[] {2, 3, 1, 1, 4}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00055();
        sut.CanJump(new[] {3, 2, 1, 0, 4}).Should().BeFalse();
    }
}