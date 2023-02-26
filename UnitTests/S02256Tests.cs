using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02256UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S02256();
        sut.MinimumAverageDifference(new[] {2, 5, 3, 9, 5, 3}).Should().Be(3);
    }

    [Test]
    public void Test2()
    {
        var sut = new S02256();
        sut.MinimumAverageDifference(new[] {0}).Should().Be(0);
    }

    [Test]
    public void Test3()
    {
        var sut = new S02256();
        sut.MinimumAverageDifference(new[] {1, 2, 3, 4, 5}).Should().Be(0);
    }
}