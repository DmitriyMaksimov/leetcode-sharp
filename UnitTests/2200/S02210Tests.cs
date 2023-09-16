using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02210Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02210();
        sut.CountHillValley(new[] {2, 4, 1, 1, 6, 5}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02210();
        sut.CountHillValley(new[] {6, 6, 5, 5, 4, 1}).Should().Be(0);
    }
}