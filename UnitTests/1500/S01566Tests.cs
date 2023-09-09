using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01566Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01566();
        sut.ContainsPattern(new[] {1, 2, 4, 4, 4, 4}, 1, 3).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01566();
        sut.ContainsPattern(new[] {1, 2, 1, 2, 1, 1, 1, 3}, 2, 2).Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S01566();
        sut.ContainsPattern(new[] {1, 2, 1, 2, 1, 3}, 2, 3).Should().BeFalse();
    }
}