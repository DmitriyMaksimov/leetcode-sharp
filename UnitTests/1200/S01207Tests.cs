using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01207Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S01207();
        sut.UniqueOccurrences(new[] {1, 2, 2, 1, 1, 3}).Should().BeTrue();
    }

    [Test]
    public void Test2()
    {
        var sut = new S01207();
        sut.UniqueOccurrences(new[] {1, 2}).Should().BeFalse();
    }

    [Test]
    public void Test3()
    {
        var sut = new S01207();
        sut.UniqueOccurrences(new[] {-3, 0, 1, -3, 1, 1, 1, -3, 10, 0}).Should().BeTrue();
    }
}