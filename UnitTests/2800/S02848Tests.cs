using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02848Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02848();
        sut.NumberOfPoints(new[] {new[] {3, 6}, new[] {1, 5}, new[] {4, 7}}).Should().Be(7);
    }

    [Test]
    public void T2()
    {
        var sut = new S02848();
        sut.NumberOfPoints(new[] {new[] {1, 3}, new[] {5, 8}}).Should().Be(7);
    }
}