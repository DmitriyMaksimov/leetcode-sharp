using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01502Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01502();
        sut.CanMakeArithmeticProgression(new[] {3, 5, 1}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01502();
        sut.CanMakeArithmeticProgression(new[] {1, 2, 4}).Should().BeFalse();
    }
}