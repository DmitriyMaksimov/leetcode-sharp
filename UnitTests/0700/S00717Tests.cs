using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00717Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00717();
        sut.IsOneBitCharacter(new[] {1, 0, 0}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00717();
        sut.IsOneBitCharacter(new[] {1, 1, 1, 0}).Should().BeFalse();
    }
}