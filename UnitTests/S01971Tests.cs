using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01971Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01971();
        sut.ValidPath(3, new[] {new[] {0, 1}, new[] {1, 2}, new[] {2, 0}}, 0, 2).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01971();
        sut.ValidPath(6, new[] {new[] {0, 1}, new[] {0, 2}, new[] {3, 5}, new[] {5, 4}, new[] {4, 3}}, 0, 5).Should().BeFalse();
    }
}