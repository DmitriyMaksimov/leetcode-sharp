using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02379Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02379();
        sut.MinimumRecolors("WBBWWBBWBW", 7).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02379();
        sut.MinimumRecolors("WBWBBBW", 2).Should().Be(0);
    }
}