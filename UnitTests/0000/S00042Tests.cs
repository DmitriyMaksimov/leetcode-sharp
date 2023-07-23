using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00042Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00042();
        sut.Trap(new[] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1}).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S00042();
        sut.Trap(new[] {4, 2, 0, 3, 2, 5}).Should().Be(9);
    }
}