using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02465Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02465();
        sut.DistinctAverages(new[] {4, 1, 4, 0, 3, 5}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02465();
        sut.DistinctAverages(new[] {1, 100}).Should().Be(1);
    }
}