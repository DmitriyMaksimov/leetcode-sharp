using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02246Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02246();
        sut.LongestPath(new[] {-1, 0, 0, 1, 1, 2}, "abacbe").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02246();
        sut.LongestPath(new[] {-1, 0, 0, 0}, "aabc").Should().Be(3);
    }
}