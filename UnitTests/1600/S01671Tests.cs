using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01671Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01671();
        sut.MinimumMountainRemovals([1, 3, 1]).Should().Be(0);
    }

    [Test]
    public void T2()
    {
        var sut = new S01671();
        sut.MinimumMountainRemovals([2, 1, 1, 5, 6, 2, 3, 1]).Should().Be(3);
    }
}
