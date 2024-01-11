using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02980Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02980();
        sut.HasTrailingZeros(new[] {1, 2, 3, 4, 5}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02980();
        sut.HasTrailingZeros(new[] {1, 3, 5, 7, 9}).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S02980();
        sut.HasTrailingZeros(new[] {2, 4, 8, 16}).Should().BeTrue();
    }
}