using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00064Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00064();
        sut.MinPathSum(new[] {new[] {1, 3, 1}, new[] {1, 5, 1}, new[] {4, 2, 1}}).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S00064();
        sut.MinPathSum(new[] {new[] {1, 2, 3}, new[] {4, 5, 6}}).Should().Be(12);
    }
}