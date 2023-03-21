using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00502Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00502();
        sut.FindMaximizedCapital(2, 0, new[] {1, 2, 3}, new[] {0, 1, 1}).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00502();
        sut.FindMaximizedCapital(3, 0, new[] {1, 2, 3}, new[] {0, 1, 2}).Should().Be(6);
    }
}